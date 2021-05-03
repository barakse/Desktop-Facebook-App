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
    public partial class CityInputForm : Form
    {
        private const int k_CityPanelLocationX = 48;
        private const int k_CityPanelLocationY = 102;
        private const int k_CityPanelWidth = 323;
        private const int k_CityPanelHeight = 30;
        private const string k_EmptyCityError = "You must enter a city in order to submit.";
        private readonly FriendsDiagnosticsLogic r_FriendsDiagnosticsLogic;

        public CityInputForm(FriendsDiagnosticsLogic i_FriendsDiagnosticsLogic)
        {
            r_FriendsDiagnosticsLogic = i_FriendsDiagnosticsLogic;
            InitializeComponent();
        }

        private void CityTextBox_Leave(object sender, EventArgs e)
        {
            CityPanel.Location = new System.Drawing.Point(k_CityPanelLocationX, k_CityPanelLocationY);
            CityPanel.Size = new System.Drawing.Size(k_CityPanelWidth, k_CityPanelHeight);
        }

        private void CityTextBox_Enter(object sender, EventArgs e)
        {
            CityPanel.Location = new System.Drawing.Point(k_CityPanelLocationX, k_CityPanelLocationY - 3);
            CityPanel.Size = new System.Drawing.Size(k_CityPanelWidth + 2, k_CityPanelHeight + 3);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CityTextBox.Text) == true)
            {
                MessageBox.Show(
                    k_EmptyCityError,
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                r_FriendsDiagnosticsLogic.FilterParameterSelectedValue = CityTextBox.Text;
                Close();
            }
        }
    }
}
