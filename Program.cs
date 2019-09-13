using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Thyme.Properties;
using Thyme.Utilities;
using UniversalDataBase;
using UniversalDataBase.DatabaseManager;

namespace Thyme
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Settings.Default.OperatingPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            Settings.Default.Save();
            RunApp();
        }

        static void RunApp()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            InsureSingleInstance manager = new InsureSingleInstance();
            manager.Run(Environment.GetCommandLineArgs());
        }

        [STAThread]
        public static void StartThyme(DataBaseObjectClass aDataObject)
        {
            InsureSingleInstance.DataObject = aDataObject;
            RunApp();
        }
    }
}
