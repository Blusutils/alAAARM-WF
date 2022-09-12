using System;
using System.IO;
using System.Windows.Forms;

namespace alAAARM {
    internal static class Program {
        public static string appPath = System.Reflection.Assembly.GetExecutingAssembly().Location.Replace(Path.GetFileName(System.Reflection.Assembly.GetExecutingAssembly().Location), "");
        [STAThread]
        static void Main() {
            Config.Load();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormAlaaarm());
        }
    }
}
