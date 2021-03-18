using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaffResources
{
    static class Program
    {
        public static string FilePath = Path.Combine(Environment.CurrentDirectory, "employees.txt");

        public static string TemporaryPath = Path.Combine(Environment.CurrentDirectory, "temp.txt");  // File prepared for temporary filter settings.

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
