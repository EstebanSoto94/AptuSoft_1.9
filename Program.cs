 
// Type: Aptusoft.Program
 
 
// version 1.8.0

using System;
using System.Windows.Forms;

namespace Aptusoft
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run((Form)new frmLogin());
       
    }
  }
}
