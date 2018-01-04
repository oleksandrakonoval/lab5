using System;
using System.Windows.Forms;

namespace SimCorp.IMS.SMSReceiverWFA {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SMSReceiverForm());
        }
    }
}
