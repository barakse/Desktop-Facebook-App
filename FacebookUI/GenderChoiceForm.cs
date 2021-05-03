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
    public partial class GenderChoiceForm : Form
    {
        private readonly FriendsDiagnosticsLogic r_FriendsDiagnosticsLogic;

        public GenderChoiceForm(FriendsDiagnosticsLogic i_FriendsDiagnosticsLogic)
        {
            r_FriendsDiagnosticsLogic = i_FriendsDiagnosticsLogic;
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            r_FriendsDiagnosticsLogic.FilterParameterSelectedValue = MaleRadioButton.Checked == true ? MaleRadioButton.Text : FemaleRadioButton.Text;
            Close();
        }
    }
}