using System;
using Microsoft.VisualBasic.ApplicationServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversalDataBase.DatabaseManager;

namespace Thyme.Utilities
{
    public class InsureSingleInstance : WindowsFormsApplicationBase
    {
        public static DataBaseObjectClass DataObject { set; get; }
        public InsureSingleInstance()
        {
            // Set whether the application is single instance 
            this.IsSingleInstance = true;

            //register for the Startup next instance event.

            this.StartupNextInstance += new
              StartupNextInstanceEventHandler(this_StartupNextInstance);
        }

        void this_StartupNextInstance(object sender, StartupNextInstanceEventArgs e)
        {
            string[] args = new string[0];
           
            bool exitApp = false;
            //When next instance is launched use the MainForm instance already created and call 
            //a public Load function with the command line arguments.
            
            UI form = null;

            if (this.MainForm != null)
            {
                form = (UI)this.MainForm;                                
            }
            else
                form = MainForm as UI;

            form.ApplyDataObject(DataObject);
            form.WindowState = FormWindowState.Maximized;

            if (exitApp)
            {
                form.Close();
            }
            //form.Load(e.CommandLine[1]);
        }

        protected override void OnCreateMainForm()
        {
            // Instantiate your main application form
            

            bool exitApp = false;
            bool launchedFromCmdLine = false;
            UI form = null;
            this.MainForm = new UI();
            form = (UI)this.MainForm;          
  
            if (exitApp)
                form.Close();

        }
    }
}
