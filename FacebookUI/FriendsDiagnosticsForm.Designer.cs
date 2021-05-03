namespace FacebookUI
{
    public partial class FriendsDiagnosticsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FriendsDiagnosticsForm));
            this.LoginBar = new System.Windows.Forms.Panel();
            this.ProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.FacebookLogo = new System.Windows.Forms.PictureBox();
            this.FriendsFilterResultsPanel = new System.Windows.Forms.Panel();
            this.FriendsFilterResultsLabel = new System.Windows.Forms.Label();
            this.FriendsFilterResultsList = new System.Windows.Forms.ListBox();
            this.FriendProfileLink = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FriendProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.GenderFilterButton = new System.Windows.Forms.Button();
            this.BirthyearFilterButton = new System.Windows.Forms.Button();
            this.CityFilterButton = new System.Windows.Forms.Button();
            this.MutualGroupsFilterButton = new System.Windows.Forms.Button();
            this.MutualLikedPagesFilterButton = new System.Windows.Forms.Button();
            this.MutualArtistsFilterButton = new System.Windows.Forms.Button();
            this.LoginBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacebookLogo)).BeginInit();
            this.FriendsFilterResultsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FriendProfilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginBar
            // 
            this.LoginBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(242)))));
            this.LoginBar.Controls.Add(this.ProfilePictureBox);
            this.LoginBar.Controls.Add(this.FacebookLogo);
            this.LoginBar.Location = new System.Drawing.Point(0, 0);
            this.LoginBar.Name = "LoginBar";
            this.LoginBar.Size = new System.Drawing.Size(440, 59);
            this.LoginBar.TabIndex = 1;
            // 
            // ProfilePictureBox
            // 
            this.ProfilePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProfilePictureBox.Location = new System.Drawing.Point(378, 4);
            this.ProfilePictureBox.Name = "ProfilePictureBox";
            this.ProfilePictureBox.Size = new System.Drawing.Size(50, 51);
            this.ProfilePictureBox.TabIndex = 2;
            this.ProfilePictureBox.TabStop = false;
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
            // FriendsFilterResultsPanel
            // 
            this.FriendsFilterResultsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FriendsFilterResultsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(242)))));
            this.FriendsFilterResultsPanel.Controls.Add(this.FriendsFilterResultsLabel);
            this.FriendsFilterResultsPanel.Controls.Add(this.FriendsFilterResultsList);
            this.FriendsFilterResultsPanel.Location = new System.Drawing.Point(12, 81);
            this.FriendsFilterResultsPanel.Name = "FriendsFilterResultsPanel";
            this.FriendsFilterResultsPanel.Size = new System.Drawing.Size(227, 200);
            this.FriendsFilterResultsPanel.TabIndex = 4;
            // 
            // FriendsFilterResultsLabel
            // 
            this.FriendsFilterResultsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(242)))));
            this.FriendsFilterResultsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FriendsFilterResultsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FriendsFilterResultsLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FriendsFilterResultsLabel.ForeColor = System.Drawing.Color.White;
            this.FriendsFilterResultsLabel.Location = new System.Drawing.Point(0, 0);
            this.FriendsFilterResultsLabel.Name = "FriendsFilterResultsLabel";
            this.FriendsFilterResultsLabel.Size = new System.Drawing.Size(227, 27);
            this.FriendsFilterResultsLabel.TabIndex = 2;
            this.FriendsFilterResultsLabel.Text = "Filter Results";
            this.FriendsFilterResultsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FriendsFilterResultsList
            // 
            this.FriendsFilterResultsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FriendsFilterResultsList.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FriendsFilterResultsList.FormattingEnabled = true;
            this.FriendsFilterResultsList.IntegralHeight = false;
            this.FriendsFilterResultsList.ItemHeight = 15;
            this.FriendsFilterResultsList.Location = new System.Drawing.Point(3, 27);
            this.FriendsFilterResultsList.Name = "FriendsFilterResultsList";
            this.FriendsFilterResultsList.Size = new System.Drawing.Size(221, 170);
            this.FriendsFilterResultsList.TabIndex = 1;
            this.FriendsFilterResultsList.SelectedIndexChanged += new System.EventHandler(this.FriendsFilterResultsList_SelectedIndexChanged);
            this.FriendsFilterResultsList.Leave += new System.EventHandler(this.FriendsFilterResultsList_Leave);
            // 
            // FriendProfileLink
            // 
            this.FriendProfileLink.AutoSize = true;
            this.FriendProfileLink.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FriendProfileLink.Location = new System.Drawing.Point(285, 258);
            this.FriendProfileLink.Name = "FriendProfileLink";
            this.FriendProfileLink.Size = new System.Drawing.Size(116, 24);
            this.FriendProfileLink.TabIndex = 6;
            this.FriendProfileLink.TabStop = true;
            this.FriendProfileLink.Text = "Visit Profile";
            this.FriendProfileLink.Click += new System.EventHandler(this.FriendProfileLink_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.FriendProfilePictureBox);
            this.panel1.Location = new System.Drawing.Point(254, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 174);
            this.panel1.TabIndex = 7;
            // 
            // FriendProfilePictureBox
            // 
            this.FriendProfilePictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.FriendProfilePictureBox.Location = new System.Drawing.Point(2, 2);
            this.FriendProfilePictureBox.Name = "FriendProfilePictureBox";
            this.FriendProfilePictureBox.Size = new System.Drawing.Size(170, 170);
            this.FriendProfilePictureBox.TabIndex = 5;
            this.FriendProfilePictureBox.TabStop = false;
            // 
            // GenderFilterButton
            // 
            this.GenderFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(242)))));
            this.GenderFilterButton.FlatAppearance.BorderSize = 0;
            this.GenderFilterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(242)))));
            this.GenderFilterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.GenderFilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenderFilterButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.GenderFilterButton.ForeColor = System.Drawing.Color.White;
            this.GenderFilterButton.Location = new System.Drawing.Point(12, 304);
            this.GenderFilterButton.Name = "GenderFilterButton";
            this.GenderFilterButton.Size = new System.Drawing.Size(199, 32);
            this.GenderFilterButton.TabIndex = 8;
            this.GenderFilterButton.Text = "Filter By Gender";
            this.GenderFilterButton.UseVisualStyleBackColor = false;
            this.GenderFilterButton.Click += new System.EventHandler(this.GenderFilterButton_Click);
            // 
            // BirthyearFilterButton
            // 
            this.BirthyearFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(242)))));
            this.BirthyearFilterButton.FlatAppearance.BorderSize = 0;
            this.BirthyearFilterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(242)))));
            this.BirthyearFilterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.BirthyearFilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BirthyearFilterButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.BirthyearFilterButton.ForeColor = System.Drawing.Color.White;
            this.BirthyearFilterButton.Location = new System.Drawing.Point(12, 351);
            this.BirthyearFilterButton.Name = "BirthyearFilterButton";
            this.BirthyearFilterButton.Size = new System.Drawing.Size(199, 32);
            this.BirthyearFilterButton.TabIndex = 9;
            this.BirthyearFilterButton.Text = "Filter By Birthyear";
            this.BirthyearFilterButton.UseVisualStyleBackColor = false;
            this.BirthyearFilterButton.Click += new System.EventHandler(this.BirthyearFilterButton_Click);
            // 
            // CityFilterButton
            // 
            this.CityFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(242)))));
            this.CityFilterButton.FlatAppearance.BorderSize = 0;
            this.CityFilterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(242)))));
            this.CityFilterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.CityFilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CityFilterButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.CityFilterButton.ForeColor = System.Drawing.Color.White;
            this.CityFilterButton.Location = new System.Drawing.Point(12, 398);
            this.CityFilterButton.Name = "CityFilterButton";
            this.CityFilterButton.Size = new System.Drawing.Size(199, 32);
            this.CityFilterButton.TabIndex = 10;
            this.CityFilterButton.Text = "Filter By City";
            this.CityFilterButton.UseVisualStyleBackColor = false;
            this.CityFilterButton.Click += new System.EventHandler(this.CityFilterButton_Click);
            // 
            // MutualGroupsFilterButton
            // 
            this.MutualGroupsFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(242)))));
            this.MutualGroupsFilterButton.FlatAppearance.BorderSize = 0;
            this.MutualGroupsFilterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(242)))));
            this.MutualGroupsFilterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.MutualGroupsFilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MutualGroupsFilterButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.MutualGroupsFilterButton.ForeColor = System.Drawing.Color.White;
            this.MutualGroupsFilterButton.Location = new System.Drawing.Point(229, 304);
            this.MutualGroupsFilterButton.Name = "MutualGroupsFilterButton";
            this.MutualGroupsFilterButton.Size = new System.Drawing.Size(199, 32);
            this.MutualGroupsFilterButton.TabIndex = 11;
            this.MutualGroupsFilterButton.Text = "Filter By Mutual Groups";
            this.MutualGroupsFilterButton.UseVisualStyleBackColor = false;
            this.MutualGroupsFilterButton.Click += new System.EventHandler(this.MutualGroupsFilterButton_Click);
            // 
            // MutualLikedPagesFilterButton
            // 
            this.MutualLikedPagesFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(242)))));
            this.MutualLikedPagesFilterButton.FlatAppearance.BorderSize = 0;
            this.MutualLikedPagesFilterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(242)))));
            this.MutualLikedPagesFilterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.MutualLikedPagesFilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MutualLikedPagesFilterButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.MutualLikedPagesFilterButton.ForeColor = System.Drawing.Color.White;
            this.MutualLikedPagesFilterButton.Location = new System.Drawing.Point(229, 351);
            this.MutualLikedPagesFilterButton.Name = "MutualLikedPagesFilterButton";
            this.MutualLikedPagesFilterButton.Size = new System.Drawing.Size(199, 32);
            this.MutualLikedPagesFilterButton.TabIndex = 12;
            this.MutualLikedPagesFilterButton.Text = "Filter By Mutual Pages";
            this.MutualLikedPagesFilterButton.UseVisualStyleBackColor = false;
            this.MutualLikedPagesFilterButton.Click += new System.EventHandler(this.MutualLikedPagesFilterButton_Click);
            // 
            // MutualArtistsFilterButton
            // 
            this.MutualArtistsFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(242)))));
            this.MutualArtistsFilterButton.FlatAppearance.BorderSize = 0;
            this.MutualArtistsFilterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(242)))));
            this.MutualArtistsFilterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.MutualArtistsFilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MutualArtistsFilterButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.MutualArtistsFilterButton.ForeColor = System.Drawing.Color.White;
            this.MutualArtistsFilterButton.Location = new System.Drawing.Point(229, 398);
            this.MutualArtistsFilterButton.Name = "MutualArtistsFilterButton";
            this.MutualArtistsFilterButton.Size = new System.Drawing.Size(199, 32);
            this.MutualArtistsFilterButton.TabIndex = 13;
            this.MutualArtistsFilterButton.Text = "Filter By Mutual Artists";
            this.MutualArtistsFilterButton.UseVisualStyleBackColor = false;
            this.MutualArtistsFilterButton.Click += new System.EventHandler(this.MutualArtistsFilterButton_Click);
            // 
            // FriendsDiagnosticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(440, 450);
            this.Controls.Add(this.MutualArtistsFilterButton);
            this.Controls.Add(this.MutualLikedPagesFilterButton);
            this.Controls.Add(this.MutualGroupsFilterButton);
            this.Controls.Add(this.CityFilterButton);
            this.Controls.Add(this.BirthyearFilterButton);
            this.Controls.Add(this.GenderFilterButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FriendProfileLink);
            this.Controls.Add(this.FriendsFilterResultsPanel);
            this.Controls.Add(this.LoginBar);
            this.MaximizeBox = false;
            this.Name = "FriendsDiagnosticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Friends Diagnostics";
            this.LoginBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacebookLogo)).EndInit();
            this.FriendsFilterResultsPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FriendProfilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LoginBar;
        private System.Windows.Forms.PictureBox FacebookLogo;
        private System.Windows.Forms.Panel FriendsFilterResultsPanel;
        private System.Windows.Forms.Label FriendsFilterResultsLabel;
        private System.Windows.Forms.ListBox FriendsFilterResultsList;
        private System.Windows.Forms.PictureBox FriendProfilePictureBox;
        private System.Windows.Forms.LinkLabel FriendProfileLink;
        private System.Windows.Forms.PictureBox ProfilePictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button GenderFilterButton;
        private System.Windows.Forms.Button BirthyearFilterButton;
        private System.Windows.Forms.Button CityFilterButton;
        private System.Windows.Forms.Button MutualGroupsFilterButton;
        private System.Windows.Forms.Button MutualLikedPagesFilterButton;
        private System.Windows.Forms.Button MutualArtistsFilterButton;
    }
}