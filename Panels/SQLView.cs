using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Thyme.Controls.ScintillaViewer;
using Thyme.Utilities;
using UniversalDataBase.AutomatedSQL;
using UniversalDataBase.DatabaseManager;
using UniversalDataBase.Utilities;
using WeifenLuo.WinFormsUI.Docking;

namespace Thyme.Panels
{
    public partial class SQLView : DockContent
    {
        private string sqlFileName;
        SQLTextFormatter mySQLParser;
        public ArrayList SQLFields = new ArrayList();
        public bool UseDocConn = true;        
        private String lastSearchFor = String.Empty;
        private int lastTextPosition = 0;
        private static DataBaseObjectClass _aDataObject;
        public ExportEvents.exportControlEventHandler StoreFileName { set; get; }        
        public ExportEvents.exportControlEventHandler actualDataTable { set; get; }

        public SQLView()
        {
            InitializeComponent();
            //textEditor = new Thyme.Controls.ScintillaViewer.TextArea();
            //grpEditor.Controls.Add(textEditor.TextBox);            
        }

        public static void DataInitialization(DataBaseObjectClass aDataObject)
        {
            _aDataObject = aDataObject;
        }

        private void SQLView_Load(object sender, EventArgs e)
        {

        }

        public void PlaceStoredProcInEditBox(Object sender, ExportEvents.exportControlEventArgs e)
        {
            editBox.Text += e.getData.ToString();
        }

        public void SetEditData(ReturnData toEdit)
        {
            editBox.Text = toEdit.SQLText;
            Grid = toEdit.QueryResult;
        }

        private void mnuFormatSQL_Click(object sender, EventArgs e)
        {
            String extract = RichText;
            editBox.Text = "";
            SQLStats.Rows.Clear();
            RichText = extract;
        }

        private void openSQLTextFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                sqlFileName = openFile.FileName;
                using (System.IO.StreamReader aReader = new System.IO.StreamReader(openFile.FileName))
                {
                    editBox.Text = aReader.ReadToEnd();
                }

                if (StoreFileName != null)
                    StoreFileName(sender, new ExportEvents.exportControlEventArgs(sqlFileName));
            }
        }

        private String ParseSQL(String SQL)
        {
            if(mySQLParser == null)
                mySQLParser = new SQLTextFormatter();
            SQLFields.Clear();
            mySQLParser.editBox = editBox;
            mySQLParser.AliasView = SQLStats;
            mySQLParser.SQLFields = SQLFields;
            mySQLParser.StartParsing(SQL);
            return editBox.Text;

        }
        public String SQLText
        {
            set
            {
                editBox.Text = value.Replace("&gt;", ">").Replace("%&lt;", "<").Replace("&qt", Convert.ToString('"'));
            }
        }

        public String RichText
        {
            set
            {
                if (value != null)
                    ParseSQL(value.Replace("&gt;", ">").Replace("%&lt;", "<").Replace("&qt", Convert.ToString('"')));
            }

            get
            {
                return editBox.Text.Replace(">", "&gt;").Replace("<", "%&lt;").Replace(Convert.ToString('"'), "&qt");
            }
        }


        public DataTable Grid
        {
            set
            {
                QueryView.DataSource = value;
            }
        }

        void newDataGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DataGridViewColumn xCol = QueryView.Columns[e.ColumnIndex];

                xCol.SortMode = DataGridViewColumnSortMode.Programmatic;
                ListSortDirection lstSort;
                if (xCol.Tag != null)
                {
                    lstSort = (ListSortDirection)xCol.Tag;

                    if (lstSort == ListSortDirection.Ascending)
                        lstSort = ListSortDirection.Descending;
                    else
                        lstSort = ListSortDirection.Ascending;
                }
                else
                    lstSort = ListSortDirection.Ascending;

                xCol.Tag = lstSort;

                QueryView.Sort(xCol, lstSort);
            }

        }        

        private void mnuTestSQL_Click(object sender, EventArgs e)
        {
            String thesql = "";
            
            if (editBox.SelectedText != null && editBox.SelectedText.Length > 0)
                thesql = editBox.SelectedText;
            else
                thesql = editBox.Text;
            Grid = _aDataObject.DoSelect(thesql);            
        }       

        private void SQLStats_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string searchFor = SQLStats.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (!lastSearchFor.Equals(searchFor))
            {
                lastTextPosition = editBox.Find("From");
                lastSearchFor = searchFor;
            }
            else
                lastTextPosition += searchFor.Length;
            int foundOne = editBox.Find(searchFor, lastTextPosition, RichTextBoxFinds.WholeWord);
            if (foundOne != -1)
            {
                editBox.SelectionLength = 0;
                editBox.SelectionStart = foundOne;
                editBox.SelectionLength = searchFor.Length;
                editBox.SelectionBackColor = Color.Yellow;
                editBox.ScrollToCaret();
                lastTextPosition = foundOne;
            }
            else
            {
                lastTextPosition = editBox.Find("From") - searchFor.Length;
                MessageBox.Show("End of Text");
            }
        }

        private void btnAddTables_Click(object sender, EventArgs e)
        {
            editBox.Text += TablesAndViewsUI.GetSelectedTables();
        }

        private void queryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SQLJoinRules buildNewSQL = new SQLJoinRules(TablesAndViewsUI.SelectedTables, _aDataObject.GetDatabaseType);            
            ProcessTables(buildNewSQL);


        }

        private void ProcessTables(SQLJoinRules buildNewSQL)
        {
            TablesAndViewsUI.PrepareSelectedTables();
            if (buildNewSQL.BuildJoin())
            {
                editBox.Text = buildNewSQL.SQLString;
            }
            else
            {
                editBox.Text = "Finding needed tables to build query";
                //editBox.Text = "One or more Tables found with no relevent relationships.\r\n\r\n";
                bool processAgain = false;
                List<TableName> stillNone = new List<TableName>();
                foreach (TableName aTable in buildNewSQL.NoRelationFound)
                {
                    //editBox.Text += aTable.Name + "\r\n";
                    List<Joiner> joins = new List<Joiner>();
                    if (TableRelationShips.FindNeededTable(aTable, TablesAndViewsUI.AllTables, TablesAndViewsUI.SelectedTables, joins))
                    {
                        var excludeIteratedTable = TablesAndViewsUI.SelectedTables.Tables.Where(x => !x.Name.Equals(aTable.Name)).ToList();
                        //joiners can be further resolved to find more distant relationships, will need a class for that kind of processing.
                        var joiner = TableRelationShips.CheckForeignKeyTables(joins, excludeIteratedTable);

                        if (joiner != null && !TablesAndViewsUI.SelectedTables.Tables.Any(x => x.Name.Equals(joiner.Table1.Name)))
                        {
                            TablesAndViewsUI.ExternallyCheckTable(joiner.Table1.Name);
                            //TablesAndViewsUI.SelectedTables.Tables.Add(joiner.Table1);
                            //TablesAndViewsUI.PrepareTable(TablesAndViewsUI.SelectedTables.Tables[TablesAndViewsUI.SelectedTables.Tables.Count - 1]);
                            processAgain = true;
                        }
                    }
                    else
                        stillNone.Add(aTable);
                }

                if (processAgain)
                    ProcessTables(buildNewSQL);
                else
                    editBox.Text = "No relationships found to complete query build";
            }
        }

        private void mnuExitSQLEdit_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(editBox.Text);
            UI.CloseApp();
        }

        private void exitWDataTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(actualDataTable != null)
            {
                ReturnData returnAll = new Utilities.ReturnData();
                returnAll.SQLText = editBox.Text;
                returnAll.QueryResult = (DataTable)QueryView.DataSource;
                actualDataTable(sender, new ExportEvents.exportControlEventArgs(returnAll));
                UI.CollapseUI();
            }
        }

        private void saveSQLTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = sqlFileName;
            if(saveFile.ShowDialog() == DialogResult.OK)
            {
                sqlFileName = saveFile.FileName;
                using (System.IO.StreamWriter fileWrite = new System.IO.StreamWriter(saveFile.FileName))
                {
                    fileWrite.Write(editBox.Text);
                }
                if (StoreFileName != null)
                    StoreFileName(sender, new ExportEvents.exportControlEventArgs(sqlFileName));
            }
        }

        private void saveAsSQLTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveSQLTextToolStripMenuItem_Click(sender, e);
        }

        private void exitWoSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.CloseApp();
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox about = new Thyme.AboutBox();
            about.ShowDialog();
        }
    }
}
