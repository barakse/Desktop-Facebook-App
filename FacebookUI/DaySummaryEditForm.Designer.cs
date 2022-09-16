namespace FacebookUI
{
    public partial class DaySummaryEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DaySummaryEditForm));
            this.LoginBar = new System.Windows.Forms.Panel();
            this.FacebookLogo = new System.Windows.Forms.PictureBox();
            this.DaySummaryEditPanel = new System.Windows.Forms.Panel();
            this.DaySummaryEditTextBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.LoginBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FacebookLogo)).BeginInit();
            this.DaySummaryEditPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginBar
            // 
            this.LoginBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(242)))));
            this.LoginBar.Controls.Add(this.FacebookLogo);
            this.LoginBar.Location = new System.Drawing.Point(0, 0);
            this.LoginBar.Name = "LoginBar";
            this.LoginBar.Size = new System.Drawing.Size(417, 58);
            this.LoginBar.TabIndex = 3;
            // 
            // FacebookLogo
            // 
            this.FacebookLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(242)))));
            this.FacebookLogo.Image = ((System.Drawing.Image)(resources.GetObject("FacebookLogo.Image")));
            this.FacebookLogo.Location = new System.Drawing.Point(-7, 5);
            this.FacebookLogo.Name = "FacebookLogo";
            this.FacebookLogo.Size = new System.Drawing.Size(189, 46);
            this.FacebookLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FacebookLogo.TabIndex = 1;
            this.FacebookLogo.TabStop = false;
            // 
            // DaySummaryEditPanel
            // 
            this.DaySummaryEditPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DaySummaryEditPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(242)))));
            this.DaySummaryEditPanel.Controls.Add(this.DaySummaryEditTextBox);
            this.DaySummaryEditPanel.Location = new System.Drawing.Point(12, 79);
            this.DaySummaryEditPanel.Name = "DaySummaryEditPanel";
            this.DaySummaryEditPanel.Size = new System.Drawing.Size(393, 143);
            this.DaySummaryEditPanel.TabIndex = 12;
            this.DaySummaryEditPanel.Enter += new System.EventHandler(this.DaySummaryEditPanel_Enter);
            this.DaySummaryEditPanel.Leave += new System.EventHandler(this.DaySummaryEditPanel_Leave);
            // 
            // DaySummaryEditTextBox
            // 
            this.DaySummaryEditTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DaySummaryEditTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DaySummaryEditTextBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.DaySummaryEditTextBox.Location = new System.Drawing.Point(0, 0);
            this.DaySummaryEditTextBox.Multiline = true;
            this.DaySummaryEditTextBox.Name = "DaySummaryEditTextBox";
            this.DaySummaryEditTextBox.Size = new System.Drawing.Size(393, 141);
            this.DaySummaryEditTextBox.TabIndex = 6;
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(242)))));
            this.SubmitButton.FlatAppearance.BorderSize = 0;
            this.SubmitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(242)))));
            this.SubmitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.SubmitButton.ForeColor = System.Drawing.Color.White;
            this.SubmitButton.Location = new System.Drawing.Point(109, 239);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(199, 32);
            this.SubmitButton.TabIndex = 13;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // DaySummaryEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(417, 293);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.DaySummaryEditPanel);
            this.Controls.Add(this.LoginBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DaySummaryEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sum up you day";
            this.LoginBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FacebookLogo)).EndInit();
            this.DaySummaryEditPanel.ResumeLayout(false);
            this.DaySummaryEditPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoginBar;
        private System.Windows.Forms.PictureBox FacebookLogo;
        private System.Windows.Forms.Panel DaySummaryEditPanel;
        private System.Windows.Forms.TextBox DaySummaryEditTextBox;
        private System.Windows.Forms.Button SubmitButton;
    }
}