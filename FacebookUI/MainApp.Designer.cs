using System.Windows.Forms;
using System.Drawing;

namespace FacebookUI
{
    public partial class MainApp
    {
        private readonly Color r_MainColor = Color.FromArgb((int)(byte)59, (int)(byte)89, (int)(byte)152);

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApp));
            this.LoginBar = new System.Windows.Forms.Panel();
            this.ProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.FacebookLogo = new System.Windows.Forms.PictureBox();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.FriendsList = new System.Windows.Forms.ListBox();
            this.FriendsListLabel = new System.Windows.Forms.Label();
            this.FriendsListPanel = new System.Windows.Forms.Panel();
            this.LikedPagesPanel = new System.Windows.Forms.Panel();
            this.LikedPagesLabel = new System.Windows.Forms.Label();
            this.LikedPagesList = new System.Windows.Forms.ListBox();
            this.AlbumsPanel = new System.Windows.Forms.Panel();
            this.AlbumsLabel = new System.Windows.Forms.Label();
            this.AlbumsList = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.QuotesPanel = new System.Windows.Forms.Panel();
            this.QuotesAreaLabel = new System.Windows.Forms.Label();
            this.QuotesLabel = new System.Windows.Forms.Label();
            this.GroupsPanel = new System.Windows.Forms.Panel();
            this.GroupsLabel = new System.Windows.Forms.Label();
            this.GroupsList = new System.Windows.Forms.ListBox();
            this.InspiredPeoplePanel = new System.Windows.Forms.Panel();
            this.InspiredPeopleLabel = new System.Windows.Forms.Label();
            this.InspiredPeopleList = new System.Windows.Forms.ListBox();
            this.PostButton = new System.Windows.Forms.Button();
            this.PostPanel = new System.Windows.Forms.Panel();
            this.PostTextBox = new System.Windows.Forms.TextBox();
            this.PostLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MyDiaryButton = new System.Windows.Forms.Button();
            this.FriendsDiagnosticsButton = new System.Windows.Forms.Button();
            this.LoginBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacebookLogo)).BeginInit();
            this.FriendsListPanel.SuspendLayout();
            this.LikedPagesPanel.SuspendLayout();
            this.AlbumsPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.QuotesPanel.SuspendLayout();
            this.GroupsPanel.SuspendLayout();
            this.InspiredPeoplePanel.SuspendLayout();
            this.PostPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginBar
            // 
            this.LoginBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(242)))));
            this.LoginBar.Controls.Add(this.ProfilePictureBox);
            this.LoginBar.Controls.Add(this.FacebookLogo);
            this.LoginBar.Controls.Add(this.LogoutButton);
            this.LoginBar.Location = new System.Drawing.Point(0, 0);
            this.LoginBar.Name = "LoginBar";
            this.LoginBar.Size = new System.Drawing.Size(1020, 59);
            this.LoginBar.TabIndex = 0;
            // 
            // ProfilePictureBox
            // 
            this.ProfilePictureBox.Location = new System.Drawing.Point(833, 4);
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
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.Transparent;
            this.LogoutButton.FlatAppearance.BorderSize = 0;
            this.LogoutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LogoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.ForeColor = System.Drawing.Color.White;
            this.LogoutButton.Location = new System.Drawing.Point(894, 0);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(108, 59);
            this.LogoutButton.TabIndex = 0;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // FriendsList
            // 
            this.FriendsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FriendsList.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FriendsList.FormattingEnabled = true;
            this.FriendsList.IntegralHeight = false;
            this.FriendsList.ItemHeight = 15;
            this.FriendsList.Location = new System.Drawing.Point(3, 27);
            this.FriendsList.Name = "FriendsList";
            this.FriendsList.Size = new System.Drawing.Size(181, 143);
            this.FriendsList.TabIndex = 1;
            // 
            // FriendsListLabel
            // 
            this.FriendsListLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(242)))));
            this.FriendsListLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FriendsListLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FriendsListLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FriendsListLabel.ForeColor = System.Drawing.Color.White;
            this.FriendsListLabel.Location = new System.Drawing.Point(0, 0);
            this.FriendsListLabel.Name = "FriendsListLabel";
            this.FriendsListLabel.Size = new System.Drawing.Size(187, 27);
            this.FriendsListLabel.TabIndex = 2;
            this.FriendsListLabel.Text = "Friends";
            this.FriendsListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FriendsListPanel
            // 
            this.FriendsListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FriendsListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(242)))));
            this.FriendsListPanel.Controls.Add(this.FriendsListLabel);
            this.FriendsListPanel.Controls.Add(this.FriendsList);
            this.FriendsListPanel.Location = new System.Drawing.Point(600, 3);
            this.FriendsListPanel.Name = "FriendsListPanel";
            this.FriendsListPanel.Size = new System.Drawing.Size(187, 173);
            this.FriendsListPanel.TabIndex = 3;
            // 
            // LikedPagesPanel
            // 
            this.LikedPagesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LikedPagesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(242)))));
            this.LikedPagesPanel.Controls.Add(this.LikedPagesLabel);
            this.LikedPagesPanel.Controls.Add(this.LikedPagesList);
            this.LikedPagesPanel.Location = new System.Drawing.Point(401, 3);
            this.LikedPagesPanel.Name = "LikedPagesPanel";
            this.LikedPagesPanel.Size = new System.Drawing.Size(187, 173);
            this.LikedPagesPanel.TabIndex = 4;
            // 
            // LikedPagesLabel
            // 
            this.LikedPagesLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(242)))));
            this.LikedPagesLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LikedPagesLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LikedPagesLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LikedPagesLabel.ForeColor = System.Drawing.Color.White;
            this.LikedPagesLabel.Location = new System.Drawing.Point(0, 0);
            this.LikedPagesLabel.Name = "LikedPagesLabel";
            this.LikedPagesLabel.Size = new System.Drawing.Size(187, 27);
            this.LikedPagesLabel.TabIndex = 2;
            this.LikedPagesLabel.Text = "Liked Pages";
            this.LikedPagesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LikedPagesList
            // 
            this.LikedPagesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LikedPagesList.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LikedPagesList.FormattingEnabled = true;
            this.LikedPagesList.IntegralHeight = false;
            this.LikedPagesList.ItemHeight = 15;
            this.LikedPagesList.Location = new System.Drawing.Point(3, 27);
            this.LikedPagesList.Name = "LikedPagesList";
            this.LikedPagesList.Size = new System.Drawing.Size(181, 143);
            this.LikedPagesList.TabIndex = 1;
            // 
            // AlbumsPanel
            // 
            this.AlbumsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AlbumsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(242)))));
            this.AlbumsPanel.Controls.Add(this.AlbumsLabel);
            this.AlbumsPanel.Controls.Add(this.AlbumsList);
            this.AlbumsPanel.Location = new System.Drawing.Point(600, 191);
            this.AlbumsPanel.Name = "AlbumsPanel";
            this.AlbumsPanel.Size = new System.Drawing.Size(187, 173);
            this.AlbumsPanel.TabIndex = 5;
            // 
            // AlbumsLabel
            // 
            this.AlbumsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(242)))));
            this.AlbumsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AlbumsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AlbumsLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.AlbumsLabel.ForeColor = System.Drawing.Color.White;
            this.AlbumsLabel.Location = new System.Drawing.Point(0, 0);
            this.AlbumsLabel.Name = "AlbumsLabel";
            this.AlbumsLabel.Size = new System.Drawing.Size(187, 27);
            this.AlbumsLabel.TabIndex = 2;
            this.AlbumsLabel.Text = "Albums";
            this.AlbumsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AlbumsList
            // 
            this.AlbumsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AlbumsList.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlbumsList.FormattingEnabled = true;
            this.AlbumsList.IntegralHeight = false;
            this.AlbumsList.ItemHeight = 15;
            this.AlbumsList.Location = new System.Drawing.Point(3, 27);
            this.AlbumsList.Name = "AlbumsList";
            this.AlbumsList.Size = new System.Drawing.Size(181, 143);
            this.AlbumsList.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.QuotesPanel);
            this.panel2.Controls.Add(this.GroupsPanel);
            this.panel2.Controls.Add(this.InspiredPeoplePanel);
            this.panel2.Controls.Add(this.PostButton);
            this.panel2.Controls.Add(this.PostPanel);
            this.panel2.Controls.Add(this.FriendsListPanel);
            this.panel2.Controls.Add(this.AlbumsPanel);
            this.panel2.Controls.Add(this.LikedPagesPanel);
            this.panel2.Location = new System.Drawing.Point(215, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(790, 373);
            this.panel2.TabIndex = 7;
            // 
            // QuotesPanel
            // 
            this.QuotesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.QuotesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(242)))));
            this.QuotesPanel.Controls.Add(this.QuotesAreaLabel);
            this.QuotesPanel.Controls.Add(this.QuotesLabel);
            this.QuotesPanel.Location = new System.Drawing.Point(3, 191);
            this.QuotesPanel.Name = "QuotesPanel";
            this.QuotesPanel.Size = new System.Drawing.Size(187, 173);
            this.QuotesPanel.TabIndex = 8;
            // 
            // QuotesAreaLabel
            // 
            this.QuotesAreaLabel.BackColor = System.Drawing.SystemColors.Window;
            this.QuotesAreaLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuotesAreaLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.QuotesAreaLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.QuotesAreaLabel.Location = new System.Drawing.Point(3, 27);
            this.QuotesAreaLabel.Name = "QuotesAreaLabel";
            this.QuotesAreaLabel.Size = new System.Drawing.Size(181, 143);
            this.QuotesAreaLabel.TabIndex = 3;
            this.QuotesAreaLabel.Text = "QuotesAreaLabel";
            // 
            // QuotesLabel
            // 
            this.QuotesLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(242)))));
            this.QuotesLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.QuotesLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuotesLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.QuotesLabel.ForeColor = System.Drawing.Color.White;
            this.QuotesLabel.Location = new System.Drawing.Point(0, 0);
            this.QuotesLabel.Name = "QuotesLabel";
            this.QuotesLabel.Size = new System.Drawing.Size(187, 27);
            this.QuotesLabel.TabIndex = 2;
            this.QuotesLabel.Text = "Quotes";
            this.QuotesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GroupsPanel
            // 
            this.GroupsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(242)))));
            this.GroupsPanel.Controls.Add(this.GroupsLabel);
            this.GroupsPanel.Controls.Add(this.GroupsList);
            this.GroupsPanel.Location = new System.Drawing.Point(202, 191);
            this.GroupsPanel.Name = "GroupsPanel";
            this.GroupsPanel.Size = new System.Drawing.Size(187, 173);
            this.GroupsPanel.TabIndex = 7;
            // 
            // GroupsLabel
            // 
            this.GroupsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(242)))));
            this.GroupsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupsLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.GroupsLabel.ForeColor = System.Drawing.Color.White;
            this.GroupsLabel.Location = new System.Drawing.Point(0, 0);
            this.GroupsLabel.Name = "GroupsLabel";
            this.GroupsLabel.Size = new System.Drawing.Size(187, 27);
            this.GroupsLabel.TabIndex = 2;
            this.GroupsLabel.Text = "Groups";
            this.GroupsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GroupsList
            // 
            this.GroupsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GroupsList.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupsList.FormattingEnabled = true;
            this.GroupsList.IntegralHeight = false;
            this.GroupsList.ItemHeight = 15;
            this.GroupsList.Location = new System.Drawing.Point(3, 27);
            this.GroupsList.Name = "GroupsList";
            this.GroupsList.Size = new System.Drawing.Size(181, 143);
            this.GroupsList.TabIndex = 1;
            // 
            // InspiredPeoplePanel
            // 
            this.InspiredPeoplePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InspiredPeoplePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(242)))));
            this.InspiredPeoplePanel.Controls.Add(this.InspiredPeopleLabel);
            this.InspiredPeoplePanel.Controls.Add(this.InspiredPeopleList);
            this.InspiredPeoplePanel.Location = new System.Drawing.Point(401, 191);
            this.InspiredPeoplePanel.Name = "InspiredPeoplePanel";
            this.InspiredPeoplePanel.Size = new System.Drawing.Size(187, 173);
            this.InspiredPeoplePanel.TabIndex = 6;
            // 
            // InspiredPeopleLabel
            // 
            this.InspiredPeopleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(242)))));
            this.InspiredPeopleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InspiredPeopleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InspiredPeopleLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.InspiredPeopleLabel.ForeColor = System.Drawing.Color.White;
            this.InspiredPeopleLabel.Location = new System.Drawing.Point(0, 0);
            this.InspiredPeopleLabel.Name = "InspiredPeopleLabel";
            this.InspiredPeopleLabel.Size = new System.Drawing.Size(187, 27);
            this.InspiredPeopleLabel.TabIndex = 2;
            this.InspiredPeopleLabel.Text = "Inspired People";
            this.InspiredPeopleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InspiredPeopleList
            // 
            this.InspiredPeopleList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InspiredPeopleList.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InspiredPeopleList.FormattingEnabled = true;
            this.InspiredPeopleList.IntegralHeight = false;
            this.InspiredPeopleList.ItemHeight = 15;
            this.InspiredPeopleList.Location = new System.Drawing.Point(3, 27);
            this.InspiredPeopleList.Name = "InspiredPeopleList";
            this.InspiredPeopleList.Size = new System.Drawing.Size(181, 143);
            this.InspiredPeopleList.TabIndex = 1;
            // 
            // PostButton
            // 
            this.PostButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(242)))));
            this.PostButton.FlatAppearance.BorderSize = 0;
            this.PostButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(242)))));
            this.PostButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.PostButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PostButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.PostButton.ForeColor = System.Drawing.Color.White;
            this.PostButton.Location = new System.Drawing.Point(3, 144);
            this.PostButton.Name = "PostButton";
            this.PostButton.Size = new System.Drawing.Size(386, 32);
            this.PostButton.TabIndex = 6;
            this.PostButton.Text = "Post";
            this.PostButton.UseVisualStyleBackColor = false;
            this.PostButton.Click += new System.EventHandler(this.PostButton_Click);
            // 
            // PostPanel
            // 
            this.PostPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PostPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(242)))));
            this.PostPanel.Controls.Add(this.PostTextBox);
            this.PostPanel.Controls.Add(this.PostLabel);
            this.PostPanel.Location = new System.Drawing.Point(3, 3);
            this.PostPanel.Name = "PostPanel";
            this.PostPanel.Size = new System.Drawing.Size(386, 139);
            this.PostPanel.TabIndex = 5;
            // 
            // PostTextBox
            // 
            this.PostTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PostTextBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.PostTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(103)))), ((int)(((byte)(107)))));
            this.PostTextBox.Location = new System.Drawing.Point(3, 27);
            this.PostTextBox.Multiline = true;
            this.PostTextBox.Name = "PostTextBox";
            this.PostTextBox.Size = new System.Drawing.Size(380, 109);
            this.PostTextBox.TabIndex = 3;
            this.PostTextBox.Text = "What\'s on your mind?";
            this.PostTextBox.Enter += new System.EventHandler(this.PostTextBox_Enter);
            this.PostTextBox.Leave += new System.EventHandler(this.PostTextBox_Leave);
            // 
            // PostLabel
            // 
            this.PostLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(242)))));
            this.PostLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PostLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PostLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.PostLabel.ForeColor = System.Drawing.Color.White;
            this.PostLabel.Location = new System.Drawing.Point(0, 0);
            this.PostLabel.Name = "PostLabel";
            this.PostLabel.Size = new System.Drawing.Size(386, 27);
            this.PostLabel.TabIndex = 2;
            this.PostLabel.Text = "Create Post";
            this.PostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.MyDiaryButton);
            this.panel1.Controls.Add(this.FriendsDiagnosticsButton);
            this.panel1.Location = new System.Drawing.Point(0, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 413);
            this.panel1.TabIndex = 8;
            // 
            // MyDiaryButton
            // 
            this.MyDiaryButton.BackColor = System.Drawing.Color.Transparent;
            this.MyDiaryButton.BackgroundImage = global::FacebookUI.Properties.Resources.DiaryIcon;
            this.MyDiaryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MyDiaryButton.FlatAppearance.BorderSize = 0;
            this.MyDiaryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.MyDiaryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.MyDiaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyDiaryButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyDiaryButton.ForeColor = System.Drawing.Color.White;
            this.MyDiaryButton.Location = new System.Drawing.Point(0, 209);
            this.MyDiaryButton.Name = "MyDiaryButton";
            this.MyDiaryButton.Size = new System.Drawing.Size(200, 173);
            this.MyDiaryButton.TabIndex = 2;
            this.MyDiaryButton.UseVisualStyleBackColor = false;
            this.MyDiaryButton.Click += new System.EventHandler(this.MyDiaryButton_Click);
            // 
            // FriendsDiagnosticsButton
            // 
            this.FriendsDiagnosticsButton.BackColor = System.Drawing.Color.Transparent;
            this.FriendsDiagnosticsButton.BackgroundImage = global::FacebookUI.Properties.Resources.DiagnosticIcon;
            this.FriendsDiagnosticsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FriendsDiagnosticsButton.FlatAppearance.BorderSize = 0;
            this.FriendsDiagnosticsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.FriendsDiagnosticsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.FriendsDiagnosticsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FriendsDiagnosticsButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FriendsDiagnosticsButton.ForeColor = System.Drawing.Color.White;
            this.FriendsDiagnosticsButton.Location = new System.Drawing.Point(0, 21);
            this.FriendsDiagnosticsButton.Name = "FriendsDiagnosticsButton";
            this.FriendsDiagnosticsButton.Size = new System.Drawing.Size(200, 173);
            this.FriendsDiagnosticsButton.TabIndex = 1;
            this.FriendsDiagnosticsButton.UseVisualStyleBackColor = false;
            this.FriendsDiagnosticsButton.Click += new System.EventHandler(this.FriendsDiagnosticsButton_Click);
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1020, 471);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LoginBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page";
            this.Load += new System.EventHandler(this.MainApp_Load);
            this.LoginBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacebookLogo)).EndInit();
            this.FriendsListPanel.ResumeLayout(false);
            this.LikedPagesPanel.ResumeLayout(false);
            this.AlbumsPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.QuotesPanel.ResumeLayout(false);
            this.GroupsPanel.ResumeLayout(false);
            this.InspiredPeoplePanel.ResumeLayout(false);
            this.PostPanel.ResumeLayout(false);
            this.PostPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoginBar;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.ListBox FriendsList;
        private System.Windows.Forms.Label FriendsListLabel;
        private Panel FriendsListPanel;
        private PictureBox FacebookLogo;
        private Panel LikedPagesPanel;
        private Label LikedPagesLabel;
        private ListBox LikedPagesList;
        private Panel AlbumsPanel;
        private Label AlbumsLabel;
        private ListBox AlbumsList;
        private Panel panel2;
        private Panel PostPanel;
        private TextBox PostTextBox;
        private Label PostLabel;
        private Button PostButton;
        private PictureBox ProfilePictureBox;
        private Panel panel1;
        private Panel InspiredPeoplePanel;
        private Label InspiredPeopleLabel;
        private ListBox InspiredPeopleList;
        private Panel GroupsPanel;
        private Label GroupsLabel;
        private ListBox GroupsList;
        private Panel QuotesPanel;
        private Label QuotesLabel;
        private Label QuotesAreaLabel;
        private Button FriendsDiagnosticsButton;
        private Button MyDiaryButton;
    }
}