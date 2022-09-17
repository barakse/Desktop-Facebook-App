using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookLogic;

namespace FacebookUI
{
    public partial class LoginForm : Form
    {
        private readonly MainAppFacade r_MainAppFacade;

        public LoginForm()
        {
            InitializeComponent();
            r_MainAppFacade = MainAppFacade.Instance;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                r_MainAppFacade.Login();
                new MainApp(this).ShowDialog();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
