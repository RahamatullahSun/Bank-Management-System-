using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BankManagementSystem.App
{
    class UserControlLoader
    {
        public static UserControl activeUserControl = null;
        public static void openUserControl(UserControl userControl, Panel pnl)
        {
            if (activeUserControl != null)
                activeUserControl.Controls.Clear();
            activeUserControl = userControl;
            activeUserControl.Dock = DockStyle.Fill;          
            pnl.Controls.Add(userControl);
            pnl.Tag = userControl;
            userControl.BringToFront();
            userControl.Show();

        }

    }
}
