using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AtlasWorkFlow.ErrorLogs;
using Thyme.Panels;
using Thyme.Utilities;
using UniversalDataBase;
using UniversalDataBase.DatabaseManager;
using UniversalDataBase.Utilities;
using WeifenLuo.WinFormsUI.Docking;

namespace Thyme
{
    public partial class UI : Form
    {
        private DeserializeDockContent m_deserializeDockContent;
        private TablesAndViewsUI tablesView;
        private ProceduresAndFunctions procFunctionView;
        private SQLView sqlView;
        private bool m_bSaveLayout = true;
        private DataBaseObjectClass _aDataObject;
        public static ExportEvents.exportControlEventHandler ExitWithData { set; get; }
        private static UI me;

        public UI(DataBaseObjectClass aDataObject):
           this()
        {
            ApplyDataObject(aDataObject);
        }

        public UI()
        {
            InitializeComponent();
            m_deserializeDockContent = new DeserializeDockContent(GetContentFromPersistString);
            tablesView = TablesAndViewsUI.GetPanel;           
            sqlView = new SQLView();
            sqlView.StoreFileName += SetSQLFileName;
            sqlView.actualDataTable += ExportDataTable;
            procFunctionView = ProceduresAndFunctions.GetPanel;
            procFunctionView.PlaceProcInEditWindow += sqlView.PlaceStoredProcInEditBox;
            me = this;
        }        

        public void ApplyDataObject(DataBaseObjectClass aDataObject)
        {
            if (_aDataObject == null || !_aDataObject.Equals(aDataObject))
            {
                _aDataObject = aDataObject;
                lblDB.Text = _aDataObject.DatabaseName;
                lblServer.Text = _aDataObject.ServerOrFile;
                TablesAndViewsUI.DataInitialization(_aDataObject);
                ProceduresAndFunctions.DataInitialization(_aDataObject);
                SQLView.DataInitialization(_aDataObject);
            }
        }

        public static void CollapseUI()
        {
            me.WindowState = FormWindowState.Minimized;
        }

        public static void CloseApp()
        {
            me.Close();
        }

        public void SetEditData(ReturnData toEdit)
        {
            sqlView.SetEditData(toEdit);
        }

        private void ExportDataTable(Object sender, ExportEvents.exportControlEventArgs e)
        {
            if(ExitWithData != null)
            {
                ExitWithData(sender, e);
            }
        }

        private void SetSQLFileName(Object sender, ExportEvents.exportControlEventArgs e)
        {
            txtFileName.Text = e.getData.ToString();
        }

        private void ReloadScreenConfig()
        {
            try
            {
                string configFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "DockPanel.config");

                if (File.Exists(configFile))
                {
                    dockPanel.LoadFromXml(configFile, m_deserializeDockContent);
                }
                else
                {
                    tablesView.Show(dockPanel);
                    sqlView.Show(dockPanel);
                    procFunctionView.Show(dockPanel);
                }
            }
            catch (Exception ex)
            {
                if (ErrorLogFile.LogErrors)
                    ErrorLogFile.LogError(ex.Message, ex.StackTrace);
            }
        }

        private IDockContent GetContentFromPersistString(string persistString)
        {
            if (persistString == typeof(TablesAndViewsUI).ToString())
                return tablesView;
            else if (persistString == typeof(SQLView).ToString())
                return sqlView;  
            else if (persistString == typeof(ProceduresAndFunctions).ToString())
                return procFunctionView;
            else
                return null;

        }

        private void App_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            try
            {
                
                string configFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "DockPanel.config");
                if (m_bSaveLayout)
                    dockPanel.SaveAsXml(configFile);
                else if (File.Exists(configFile))
                    File.Delete(configFile);

               
            }
            catch (Exception ex)
            {
                if (ErrorLogFile.LogErrors)
                    ErrorLogFile.LogError(ex.Message, ex.StackTrace);
            }
            ErrorLogFile.CloseErrorFile();

        }

        private void CloseAllDocuments()
        {
            try
            {
                if (dockPanel.DocumentStyle == DocumentStyle.SystemMdi)
                {
                    foreach (Form form in MdiChildren)
                        form.Close();
                }
                else
                {
                    for (int index = dockPanel.Contents.Count - 1; index >= 0; index--)
                    {
                        if (dockPanel.Contents[index] is IDockContent)
                        {
                            IDockContent content = (IDockContent)dockPanel.Contents[index];
                            content.DockHandler.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (ErrorLogFile.LogErrors)
                    ErrorLogFile.LogError(ex.Message, ex.StackTrace);
            }
        }

        private void UI_Load(object sender, EventArgs e)
        {
            ReloadScreenConfig();
        }

        private void tsbDbConnect_Click(object sender, EventArgs e)
        {
            DataBaseSelection openDatabase = new DataBaseSelection();
            openDatabase.IntitialFolderPath = Application.StartupPath;
            
            if (openDatabase.ShowDialog() == DialogResult.OK)
            {
                DataLogin dataLogin = openDatabase.Connection;
                _aDataObject = new DataBaseObjectClass(dataLogin.FromDatabase.DataBaseType);
                _aDataObject.Connection(dataLogin.FromDatabase.ServerFile, dataLogin.FromDatabase.DatabaseName, dataLogin.FromDatabase.UserID, dataLogin.FromDatabase.Password, dataLogin.FromDatabase.Integrated);
                lblDB.Text = _aDataObject.DatabaseName;
                lblServer.Text = _aDataObject.ServerOrFile;
                TablesAndViewsUI.DataInitialization(_aDataObject);
                ProceduresAndFunctions.DataInitialization(_aDataObject);
                SQLView.DataInitialization(_aDataObject);
            }
        }        
    }
}
