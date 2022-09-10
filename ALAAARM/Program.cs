using System;
using System.Windows.Forms;

namespace alAAARM {
    internal static class Program {
        [STAThread]
        static void Main() {
            Config.Load();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormAlaaarm());
        }
    }
}
