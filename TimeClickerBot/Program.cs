using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeClickerBot
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var processName = Process.GetCurrentProcess().ProcessName;

            if (Process.GetProcesses().Count(x => x.ProcessName == processName) > 1)
            {
                MessageBox.Show("TimeClickerBot is already running", "TimeClickerBot - By Tobias Savinainen", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TimeClickerForm());
        }
    }
}
