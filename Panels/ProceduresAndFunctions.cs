using System;
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
using UniversalDataBase.DatabaseManager;
using UniversalDataBase.Enums;
using WeifenLuo.WinFormsUI.Docking;

namespace Thyme.Panels
{
    public partial class ProceduresAndFunctions : DockContent
    {
        private static DataBaseObjectClass _aDataObject;
        public bool UseDocConn = true;
        private static ProceduresAndFunctions singleTon;
        private ExtendedLoadSchemaData schemaLoader;
        public ExportEvents.exportControlEventHandler PlaceProcInEditWindow { set; get; }
        private bool lockout;

        private ProceduresAndFunctions()
        {
            InitializeComponent();
            schemaLoader = new Utilities.ExtendedLoadSchemaData();
        }

        public static ProceduresAndFunctions GetPanel
        {
            get
            {
                if (singleTon == null || singleTon.IsDisposed)
                    singleTon = new ProceduresAndFunctions();

                return singleTon;
            }
        }

        private void cboProcs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lockout) return;
            if (UseDocConn)
            {
                dgrdParams.DataSource = _aDataObject.GetSchemaData(SchemaRestrictions.ProcedureParameters, cboProcedures.SelectedItem.ToString());
                HideColumns();
                ShowOnlyColumns();
            }
        }
        private void ShowOnlyColumns()
        {
            dgrdParams.Columns["Parameter_Name".ToUpper()].Visible = true;
            dgrdParams.Columns["Data_Type".ToUpper()].Visible = true;
            dgrdParams.Columns["Character_Maximum_Length".ToUpper()].Visible = true;
        }

        private void HideColumns()
        {
            foreach(DataGridViewColumn aCol in dgrdParams.Columns)
            {
                aCol.Visible = false;
            }
        }

        public static void DataInitialization(DataBaseObjectClass aDataObject)
        {
            _aDataObject = aDataObject;
            singleTon.schemaLoader.LoadToSQLEditor(singleTon.cboProcedures, SchemaRestrictions.Procedures, "ROUTINE_NAME", aDataObject);
            //singleTon.schemaLoader.LoadToSQLEditor(singleTon.cboFunctions, SchemaRestrictions.Functions, "FUNCTION_NAME", aDataObject);
        }

        private void mnuPlaceToEditWindow_Click(object sender, EventArgs e)
        {
            if(PlaceProcInEditWindow != null)
            {
                string storeProc = String.Format("GO {0} ", cboProcedures.SelectedItem.ToString());
                int idx = dgrdParams.Columns.IndexOf(dgrdParams.Columns["Parameter_Name".ToUpper()]);
                foreach(DataGridViewRow aRow in dgrdParams.Rows)
                {
                    if(aRow.Cells[idx].Value != null)
                        storeProc += aRow.Cells[idx].Value.ToString() + " ";
                }

                PlaceProcInEditWindow(sender, new ExportEvents.exportControlEventArgs(storeProc));
            }
        }
    }
}
