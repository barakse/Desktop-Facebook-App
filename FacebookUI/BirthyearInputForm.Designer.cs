namespace FacebookUI
{
    public partial class BirthyearInputForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BirthyearInputForm));
            this.LoginBar = new System.Windows.Forms.Panel();
            this.FacebookLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BirthyearTextBox = new System.Windows.Forms.TextBox();
            this.BirthyearPanel = new System.Windows.Forms.Panel();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.LoginBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FacebookLogo)).BeginInit();
            this.BirthyearPanel.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(8, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Which birthyear would you like to filter your friends list?";
            // 
            // BirthyearTextBox
            // 
            this.BirthyearTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BirthyearTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BirthyearTextBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.BirthyearTextBox.Location = new System.Drawing.Point(0, 0);
            this.BirthyearTextBox.Name = "BirthyearTextBox";
            this.BirthyearTextBox.Size = new System.Drawing.Size(154, 28);
            this.BirthyearTextBox.TabIndex = 6;
            this.BirthyearTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BirthyearTextBox.Enter += new System.EventHandler(this.BirthyearTextBox_Enter);
            this.BirthyearTextBox.Leave += new System.EventHandler(this.BirthyearTextBox_Leave);
            // 
            // BirthyearPanel
            // 
            this.BirthyearPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthyearPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(242)))));
            this.BirthyearPanel.Controls.Add(this.BirthyearTextBox);
            this.BirthyearPanel.Location = new System.Drawing.Point(132, 102);
            this.BirthyearPanel.Name = "BirthyearPanel";
            this.BirthyearPanel.Size = new System.Drawing.Size(154, 30);
            this.BirthyearPanel.TabIndex = 5;
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
            this.SubmitButton.Location = new System.Drawing.Point(108, 157);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(199, 32);
            this.SubmitButton.TabIndex = 10;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // BirthyearInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(417, 201);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.BirthyearPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BirthyearInputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter a birthyear";
            this.LoginBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FacebookLogo)).EndInit();
            this.BirthyearPanel.ResumeLayout(false);
            this.BirthyearPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LoginBar;
        private System.Windows.Forms.PictureBox FacebookLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BirthyearTextBox;
        private System.Windows.Forms.Panel BirthyearPanel;
        private System.Windows.Forms.Button SubmitButton;
    }
}