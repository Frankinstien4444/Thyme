using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversalDataBase;
using UniversalDataBase.DatabaseManager;
using UniversalDataBase.Enums;
using UniversalDataBase.Utilities;

namespace Thyme.Utilities
{
    public class ExtendedLoadSchemaData : LoadSchemaData
    {
        public ExtendedLoadSchemaData()
        {
            this.SendMessage = RecieveMessage;
        }

        private void RecieveMessage(String msg)
        {
            MessageBox.Show(msg);
        }

        public void LoadToSQLEditor(CheckedListBox chckList, SchemaRestrictions restriction, String tableName, String extractField, DataBaseObjectClass aDataObject)
        {
            LoadToSQLEditor(chckList, restriction, tableName, extractField, null, aDataObject);
        }      

        public DataTable LoadSchema(SchemaRestrictions restriction, String tableName, DataBaseObjectClass aDataObject)
        {
            return aDataObject.GetSchemaData(restriction, tableName);
        }

        public void LoadToSQLEditor(CheckedListBox chckList, SchemaRestrictions restriction, String tableName, String extractField, string tableType, DataBaseObjectClass aDataObject)
        {
            LoadToSQLEditor(chckList, LoadSchema(restriction, tableName, aDataObject), restriction, extractField, tableType);
        }
        public void LoadToSQLEditor(CheckedListBox chckList, DataTable schemaData, SchemaRestrictions restriction, String extractField, string tableType)
        {
            chckList.Items.Clear();
            if (schemaData != null)
            {
                
                foreach (DataRow aRow in schemaData.Rows)
                {
                    bool loadIt = true;

                    switch (restriction)
                    {
                        case SchemaRestrictions.Tables:
                            if (!aRow["TABLE_TYPE"].ToString().Equals(tableType))
                                loadIt = false;
                            break;
                    }
                    
                    if(loadIt)
                        chckList.Items.Add(aRow[extractField].ToString());
                }
            }
            else
                MessageBox.Show("Restriction not valid");
        }        

        public void LoadToSQLEditor(ComboBox chckList, SchemaRestrictions restriction, String extractField, DataBaseObjectClass aDataObject)
        {
            DataTable dt = aDataObject.GetSchemaData(restriction, null);
            chckList.Items.Clear();
            if (dt != null)
            {

                foreach (DataRow aRow in dt.Rows)
                {
                    chckList.Items.Add(aRow[extractField].ToString());
                }
            }
            else
                MessageBox.Show("Restriction not valid");
        }
    }
}
