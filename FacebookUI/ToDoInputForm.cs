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
    public partial class ToDoInputForm : Form
    {
        private const int k_ToDoItemPanelLocationX = 12;
        private const int k_ToDoItemPanelLocationY = 79;
        private const int k_ToDoItemPanelWidth = 393;
        private const int k_ToDoItemPanelHeight = 30;
        private const string k_EmptyToDoItemError = "You must enter a to do task in order to submit.";
        private readonly MyDiaryLogic r_DiaryLogic;

        public ToDoInputForm(MyDiaryLogic i_DiaryLogic)
        {
            r_DiaryLogic = i_DiaryLogic;
            InitializeComponent();
        }

        private void ToDoItemTextBox_Enter(object sender, EventArgs e)
        {
            ToDoItemPanel.Location = new System.Drawing.Point(k_ToDoItemPanelLocationX, k_ToDoItemPanelLocationY - 3);
            ToDoItemPanel.Size = new System.Drawing.Size(k_ToDoItemPanelWidth + 2, k_ToDoItemPanelHeight + 3);
        }

        private void ToDoItemTextBox_Leave(object sender, EventArgs e)
        {
            ToDoItemPanel.Location = new System.Drawing.Point(k_ToDoItemPanelLocationX, k_ToDoItemPanelLocationY);
            ToDoItemPanel.Size = new System.Drawing.Size(k_ToDoItemPanelWidth, k_ToDoItemPanelHeight);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ToDoItemTextBox.Text) == true)
            {
                MessageBox.Show(
                    k_EmptyToDoItemError,
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                r_DiaryLogic.ToDoNewItem = ToDoItemTextBox.Text;
                Close();
            }
        }
    }
}
