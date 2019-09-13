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
using Thyme.Utilities;
using UniversalDataBase;
using UniversalDataBase.AutomatedSQL;
using UniversalDataBase.DatabaseManager;
using UniversalDataBase.Enums;
using UniversalDataBase.Utilities;
using WeifenLuo.WinFormsUI.Docking;

namespace Thyme.Panels
{
    public partial class TablesAndViewsUI : DockContent
    {
        private static DataBaseObjectClass _aDataObject;
        public static TableCollection SelectedTables { get; set; }
        public static TableCollection AllTables { get; set; }
        private static TablesAndViewsUI singleTon;
        public ArrayList SQLFields = new ArrayList();
        private bool lockout;
        private ExtendedLoadSchemaData schemaLoader;

        public static TablesAndViewsUI GetPanel
        {
            get
            {
                if (singleTon == null || singleTon.IsDisposed)
                    singleTon = new TablesAndViewsUI();

                return singleTon;
            }
        }

        public static String GetSelectedTables()
        {
            String result = String.Empty;
            foreach (Object item in singleTon.chkListTables.CheckedItems)
            {
                result += item.ToString() + " ";
            }

            return result;
        }

        private TablesAndViewsUI()
        {
            InitializeComponent();
            schemaLoader = new Utilities.ExtendedLoadSchemaData();
        }

        public static void DataInitialization(DataBaseObjectClass aDataObject)
        {
            _aDataObject = aDataObject;
            DataTable dt = singleTon.schemaLoader.LoadSchema(SchemaRestrictions.Tables, null, _aDataObject);
            singleTon.schemaLoader.LoadToSQLEditor(singleTon.chkListTables, dt, SchemaRestrictions.Tables, "TABLE_NAME", "BASE TABLE");
            singleTon.schemaLoader.LoadToSQLEditor(singleTon.chkViews, dt, SchemaRestrictions.Tables, "TABLE_NAME", "VIEW");
            SelectedTables = new TableCollection(_aDataObject.GetDatabaseType);
            AllTables = new TableCollection(_aDataObject.GetDatabaseType);
            AllTables.UsePrefixes = true;
            SelectedTables.UsePrefixes = true;            
            singleTon.searchBar2.SearchableObject = singleTon.chkViews;
            singleTon.searchBar1.SearchableObject = singleTon.chkListTables;
            LoadAllTables();
        }

        public static void PrepareSelectedTables()
        {
            foreach (TableName aTable in SelectedTables.Tables)
            {
                PrepareTable(aTable);
            }
        }

        public static void PrepareTable(TableName aTable)
        {
            aTable.ForeignKeys = singleTon.schemaLoader.LoadToList(FormatSQLParser.ForeignKeyQueryString(aTable.Name, FormatSQLParser.MSSQL_ForeignKeyQuery), _aDataObject);
            aTable.PrimaryKeys = singleTon.schemaLoader.LoadToList(FormatSQLParser.PrimaryKeyQueryString(aTable.Name, FormatSQLParser.MSSQL_PrimaryKeyQuery), "ColumnName", _aDataObject);
            aTable.AlternativeKeys = singleTon.schemaLoader.LoadToList(SchemaRestrictions.Columns, aTable.Name, "COLUMN_NAME", _aDataObject);
        }

        private static void LoadAllTables()
        {
            for (int i = 0; i < singleTon.chkListTables.Items.Count; i++)
                    AllTables.CreateTableEntry(singleTon.chkListTables.Items[i].ToString());
            foreach (TableName aTable in TablesAndViewsUI.AllTables.Tables)
            {
                aTable.ForeignKeys = singleTon.schemaLoader.LoadToList(FormatSQLParser.ForeignKeyQueryString(aTable.Name, FormatSQLParser.MSSQL_ForeignKeyQuery), _aDataObject);
                aTable.PrimaryKeys = singleTon.schemaLoader.LoadToList(FormatSQLParser.PrimaryKeyQueryString(aTable.Name, FormatSQLParser.MSSQL_PrimaryKeyQuery), "ColumnName", _aDataObject);
                aTable.AlternativeKeys = singleTon.schemaLoader.LoadToList(SchemaRestrictions.Columns, aTable.Name, "COLUMN_NAME", _aDataObject);
            }
        }

        private void chkListTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lockout) return;
            CheckedListBox currentBox = (CheckedListBox)sender;
            schemaLoader.LoadToSQLEditor(chkListFields, SchemaRestrictions.Columns, currentBox.SelectedItem.ToString(), "COLUMN_NAME", _aDataObject);
            CheckIfFieldIsSelected(currentBox.SelectedItem.ToString());
        } 
        
        private void CheckIfFieldIsSelected(String selectedTable)
        {
            for(int x=0;x<chkListFields.Items.Count;x++)
            {
                if (SelectedTables.IsFieldSelected(selectedTable, chkListFields.Items[x].ToString()))
                    chkListFields.SetItemChecked(x, true);
            }
        }

        private void chkListTables_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox currentBox = (CheckedListBox)sender;
            if (e.NewValue.Equals(CheckState.Checked))
            {
                SelectedTables.CreateTableEntry(currentBox.Items[e.Index].ToString());
            }
            else if (e.NewValue.Equals(CheckState.Unchecked))
            {
                SelectedTables.RemoveTable(currentBox.Items[e.Index].ToString());
            }
            chkListFields.Tag = currentBox;
        }

        public static void ExternallyCheckTable(String tableName)
        {
            int i = singleTon.chkListTables.FindString(tableName);
            if (i > -1)
                singleTon.chkListTables.SetItemChecked(i, true);
        }

        private void chkListFields_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox currentBox = (CheckedListBox)chkListFields.Tag;
            CheckState tableChecked = currentBox.GetItemCheckState(currentBox.SelectedIndex);
            if (e.NewValue.Equals(CheckState.Checked) && tableChecked == CheckState.Checked)
            {
                if (!SelectedTables.IsFieldSelected(currentBox.SelectedItem.ToString(), chkListFields.Items[e.Index].ToString()))
                    SelectedTables.AddTableField(currentBox.SelectedItem.ToString(), chkListFields.Items[e.Index].ToString());
            }
            else if (e.NewValue.Equals(CheckState.Unchecked) && tableChecked == CheckState.Checked)
            {
                SelectedTables.RemoveTableField(currentBox.SelectedItem.ToString(), chkListFields.Items[e.Index].ToString());
            }
        }

        private void TablesAndViewsUI_DockChanged(object sender, EventArgs e)
        {
            
        }

        private void TablesAndViewsUI_DockStateChanged(object sender, EventArgs e)
        {
            //if (this.DockState == DockState.Hidden && mainPanel.RowStyles.Count == 3)
            //{
            //    mainPanel.RowStyles.RemoveAt(2);
            //}
            //else
            //{
            //    mainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 39.0f));
            //}
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chkListFields.Items.Count; i++)
            {
                chkListFields.SetItemChecked(i, true);
            }
        }

        private void deselectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for(int i=0;i< chkListFields.Items.Count;i++)
            {
                chkListFields.SetItemChecked(i, false);
            }
        }
        
    }
}
