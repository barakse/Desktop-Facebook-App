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
    public partial class DaySummaryEditForm : Form
    {
        private const int k_DaySummaryEditPanelLocationX = 12;
        private const int k_DaySummaryEditPanelLocationY = 79;
        private const int k_DaySummaryEditItemPanelWidth = 393;
        private const int k_DaySummaryEditItemPanelHeight = 143;
        private readonly MyDiaryLogic r_DiaryLogic;
        
        public DaySummaryEditForm(MyDiaryLogic i_DiaryLogic)
        {
            r_DiaryLogic = i_DiaryLogic;
            InitializeComponent();
            DaySummaryEditTextBox.Text = r_DiaryLogic.ChosenDaySummary;
        }

        private void DaySummaryEditPanel_Enter(object sender, EventArgs e)
        {
            DaySummaryEditPanel.Location = new System.Drawing.Point(k_DaySummaryEditPanelLocationX, k_DaySummaryEditPanelLocationY - 3);
            DaySummaryEditPanel.Size = new System.Drawing.Size(k_DaySummaryEditItemPanelWidth + 2, k_DaySummaryEditItemPanelHeight + 2);
        }

        private void DaySummaryEditPanel_Leave(object sender, EventArgs e)
        {
            DaySummaryEditPanel.Location = new System.Drawing.Point(k_DaySummaryEditPanelLocationX, k_DaySummaryEditPanelLocationY);
            DaySummaryEditPanel.Size = new System.Drawing.Size(k_DaySummaryEditItemPanelWidth, k_DaySummaryEditItemPanelHeight);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            r_DiaryLogic.ChosenDaySummary = DaySummaryEditTextBox.Text;
            Close();
        }
    }
}
