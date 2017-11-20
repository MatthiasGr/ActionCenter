using System.Diagnostics;
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
                icon.Icon = Resources.Icon;
                icon.MouseClick += (s, e) =>
                {
                    if(e.Button == MouseButtons.Left)
                        Process.Start("ms-actioncenter://");
                };
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
