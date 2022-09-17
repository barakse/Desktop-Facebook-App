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
        private readonly FiltersFacade r_FiltersFacade;

        public GenderChoiceForm(FiltersFacade i_FiltersFacade)
        {
            r_FiltersFacade = i_FiltersFacade;
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            r_FiltersFacade.FilterParameterSelectedValue = MaleRadioButton.Checked == true ? MaleRadioButton.Text : FemaleRadioButton.Text;
            Close();
        }
    }
}