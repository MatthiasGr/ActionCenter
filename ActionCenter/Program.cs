using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActionCenter
{
    class Program
    {
        static void Main()
        {
            using (var icon = new NotifyIcon())
            {
                icon.Text = Resources.ActionCenter;

                icon.ContextMenu = new ContextMenu(new []
                {
                    new MenuItem(Resources.ShowActionCenter, (s, e) => Process.Start("ms-actioncenter://")),
                    new MenuItem(Resources.Exit, (s, e) => Application.Exit()) 
                });

                icon.Visible = true;
                Application.Run();
            }
        }
    }
}
