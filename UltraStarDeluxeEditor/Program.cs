using System;
using System.Windows.Forms;

namespace UltraStarDeluxeEditor {
    internal static class Program {
        /**
         * The main entry point for the application.
         */
        [STAThread]
        private static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}