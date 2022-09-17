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
    public partial class BirthyearInputForm : Form
    {
        private const int k_BirthYearPanelLocationX = 132;
        private const int k_BirthYearPanelLocationY = 102;
        private const int k_BirthYearPanelWidth = 154;
        private const int k_BirthYearPanelHeight = 30;
        private const string k_EmptyBirthyearError = "You must enter a birthyear in order to submit.";
        private const string k_NonNumericBirthyearError = "Birthyear must be a numeric (e.g: 2021), enter birthyear again in order to submit.";
        private readonly FiltersFacade r_FiltersFacade;

        public BirthyearInputForm(FiltersFacade i_FiltersFacade)
        {
            r_FiltersFacade = i_FiltersFacade;
            InitializeComponent();
        }

        private void BirthyearTextBox_Leave(object sender, EventArgs e)
        {
            BirthyearPanel.Location = new System.Drawing.Point(k_BirthYearPanelLocationX, k_BirthYearPanelLocationY);
            BirthyearPanel.Size = new System.Drawing.Size(k_BirthYearPanelWidth, k_BirthYearPanelHeight);
        }

        private void BirthyearTextBox_Enter(object sender, EventArgs e)
        {
            BirthyearPanel.Location = new System.Drawing.Point(k_BirthYearPanelLocationX, k_BirthYearPanelLocationY - 3);
            BirthyearPanel.Size = new System.Drawing.Size(k_BirthYearPanelWidth + 2, k_BirthYearPanelHeight + 3);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            bool isValidBirthYear = int.TryParse(BirthyearTextBox.Text, out int year);

            if(string.IsNullOrEmpty(BirthyearTextBox.Text) == true)
            {
                MessageBox.Show(
                    k_EmptyBirthyearError,
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else if(!isValidBirthYear)
            {
                MessageBox.Show(
                    k_NonNumericBirthyearError,
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                r_FiltersFacade.FilterParameterSelectedValue = BirthyearTextBox.Text;
                Close();
            }
        }
    }
}
