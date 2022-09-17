using System.Drawing;
using System.Windows.Forms;

namespace FacebookUI
{
    public partial class MyDiaryForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyDiaryForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LoginBar = new System.Windows.Forms.Panel();
            this.ProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.FacebookLogo = new System.Windows.Forms.PictureBox();
            this.MonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.EventsDataGrid = new System.Windows.Forms.DataGridView();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuotesPanel = new System.Windows.Forms.Panel();
            this.NoDaySummaryLabel = new System.Windows.Forms.Label();
            this.EditDaySummaryButton = new System.Windows.Forms.Button();
            this.DaySummaryAreaLabel = new System.Windows.Forms.Label();
            this.DaySummaryLabel = new System.Windows.Forms.Label();
            this.FriendsListPanel = new System.Windows.Forms.Panel();
            this.NoToDosLabel = new System.Windows.Forms.Label();
            this.ToDoListDeleteItemButton = new System.Windows.Forms.Button();
            this.ToDoListAddItemButton = new System.Windows.Forms.Button();
            this.TodayToDoLabel = new System.Windows.Forms.Label();
            this.TodayToDoList = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NoEventsLabel = new System.Windows.Forms.Label();
            this.EventsLabel = new System.Windows.Forms.Label();
            this.daySummariesDictionaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EventDetailsPanel = new System.Windows.Forms.Panel();
            this.EventTicketsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.EventLocationLabel = new System.Windows.Forms.Label();
            this.EventOwnerLabel = new System.Windows.Forms.Label();
            this.EventEndTimeLabel = new System.Windows.Forms.Label();
            this.EventStartTimeLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EventCoverPicture = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventLink = new System.Windows.Forms.DataGridViewLinkColumn();
            this.LoginBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacebookLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            this.QuotesPanel.SuspendLayout();
            this.FriendsListPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.daySummariesDictionaryBindingSource)).BeginInit();
            this.EventDetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EventCoverPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginBar
            // 
            this.LoginBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(242)))));
            this.LoginBar.Controls.Add(this.ProfilePictureBox);
            this.LoginBar.Controls.Add(this.FacebookLogo);
            this.LoginBar.Location = new System.Drawing.Point(0, 0);
            this.LoginBar.Name = "LoginBar";
            this.LoginBar.Size = new System.Drawing.Size(667, 59);
            this.LoginBar.TabIndex = 2;
            // 
            // ProfilePictureBox
            // 
            this.ProfilePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProfilePictureBox.Location = new System.Drawing.Point(605, 4);
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
            // MonthCalendar
            // 
            this.MonthCalendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.MonthCalendar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.MonthCalendar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MonthCalendar.Location = new System.Drawing.Point(428, 70);
            this.MonthCalendar.MaximumSize = new System.Drawing.Size(227, 224);
            this.MonthCalendar.MinDate = new System.DateTime(1793, 1, 1, 0, 0, 0, 0);
            this.MonthCalendar.MinimumSize = new System.Drawing.Size(227, 224);
            this.MonthCalendar.Name = "MonthCalendar";
            this.MonthCalendar.ShowToday = false;
            this.MonthCalendar.TabIndex = 3;
            this.MonthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendar_DateSelected);
            // 
            // EventsDataGrid
            // 
            this.EventsDataGrid.AllowUserToAddRows = false;
            this.EventsDataGrid.AllowUserToDeleteRows = false;
            this.EventsDataGrid.AllowUserToResizeColumns = false;
            this.EventsDataGrid.AutoGenerateColumns = false;
            this.EventsDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.EventsDataGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.EventsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EventsDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EventsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EventName,
            this.EventLink});
            this.EventsDataGrid.DataSource = this.eventBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EventsDataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.EventsDataGrid.Location = new System.Drawing.Point(3, 27);
            this.EventsDataGrid.MultiSelect = false;
            this.EventsDataGrid.Name = "EventsDataGrid";
            this.EventsDataGrid.ReadOnly = true;
            this.EventsDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.EventsDataGrid.RowHeadersVisible = false;
            this.EventsDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EventsDataGrid.Size = new System.Drawing.Size(393, 194);
            this.EventsDataGrid.TabIndex = 4;
            this.EventsDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EventsDataGrid_CellClick);
            this.EventsDataGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.EventsDataGrid_CellFormatting);
            this.EventsDataGrid.SelectionChanged += new System.EventHandler(this.EventsDataGrid_SelectionChanged);
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // QuotesPanel
            // 
            this.QuotesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.QuotesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(242)))));
            this.QuotesPanel.Controls.Add(this.NoDaySummaryLabel);
            this.QuotesPanel.Controls.Add(this.EditDaySummaryButton);
            this.QuotesPanel.Controls.Add(this.DaySummaryAreaLabel);
            this.QuotesPanel.Controls.Add(this.DaySummaryLabel);
            this.QuotesPanel.Location = new System.Drawing.Point(344, 456);
            this.QuotesPanel.Name = "QuotesPanel";
            this.QuotesPanel.Size = new System.Drawing.Size(311, 173);
            this.QuotesPanel.TabIndex = 9;
            // 
            // NoDaySummaryLabel
            // 
            this.NoDaySummaryLabel.BackColor = System.Drawing.SystemColors.Window;
            this.NoDaySummaryLabel.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.NoDaySummaryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NoDaySummaryLabel.Location = new System.Drawing.Point(3, 27);
            this.NoDaySummaryLabel.Name = "NoDaySummaryLabel";
            this.NoDaySummaryLabel.Size = new System.Drawing.Size(305, 143);
            this.NoDaySummaryLabel.TabIndex = 9;
            this.NoDaySummaryLabel.Text = "No Day Summary";
            this.NoDaySummaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NoDaySummaryLabel.Visible = false;
            // 
            // EditDaySummaryButton
            // 
            this.EditDaySummaryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(242)))));
            this.EditDaySummaryButton.BackgroundImage = global::FacebookUI.Properties.Resources.EditIcon;
            this.EditDaySummaryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EditDaySummaryButton.FlatAppearance.BorderSize = 0;
            this.EditDaySummaryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(242)))));
            this.EditDaySummaryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.EditDaySummaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditDaySummaryButton.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditDaySummaryButton.ForeColor = System.Drawing.Color.White;
            this.EditDaySummaryButton.Location = new System.Drawing.Point(281, 0);
            this.EditDaySummaryButton.Margin = new System.Windows.Forms.Padding(0);
            this.EditDaySummaryButton.Name = "EditDaySummaryButton";
            this.EditDaySummaryButton.Size = new System.Drawing.Size(27, 27);
            this.EditDaySummaryButton.TabIndex = 9;
            this.EditDaySummaryButton.UseVisualStyleBackColor = false;
            this.EditDaySummaryButton.Click += new System.EventHandler(this.EditDaySummaryButton_Click);
            // 
            // DaySummaryAreaLabel
            // 
            this.DaySummaryAreaLabel.BackColor = System.Drawing.SystemColors.Window;
            this.DaySummaryAreaLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DaySummaryAreaLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.DaySummaryAreaLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DaySummaryAreaLabel.Location = new System.Drawing.Point(3, 27);
            this.DaySummaryAreaLabel.Name = "DaySummaryAreaLabel";
            this.DaySummaryAreaLabel.Size = new System.Drawing.Size(305, 143);
            this.DaySummaryAreaLabel.TabIndex = 3;
            // 
            // DaySummaryLabel
            // 
            this.DaySummaryLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(242)))));
            this.DaySummaryLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DaySummaryLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DaySummaryLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.DaySummaryLabel.ForeColor = System.Drawing.Color.White;
            this.DaySummaryLabel.Location = new System.Drawing.Point(0, 0);
            this.DaySummaryLabel.Name = "DaySummaryLabel";
            this.DaySummaryLabel.Size = new System.Drawing.Size(311, 27);
            this.DaySummaryLabel.TabIndex = 2;
            this.DaySummaryLabel.Text = "Day Summary";
            this.DaySummaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FriendsListPanel
            // 
            this.FriendsListPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FriendsListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(242)))));
            this.FriendsListPanel.Controls.Add(this.NoToDosLabel);
            this.FriendsListPanel.Controls.Add(this.ToDoListDeleteItemButton);
            this.FriendsListPanel.Controls.Add(this.ToDoListAddItemButton);
            this.FriendsListPanel.Controls.Add(this.TodayToDoLabel);
            this.FriendsListPanel.Controls.Add(this.TodayToDoList);
            this.FriendsListPanel.Location = new System.Drawing.Point(12, 456);
            this.FriendsListPanel.Name = "FriendsListPanel";
            this.FriendsListPanel.Size = new System.Drawing.Size(312, 173);
            this.FriendsListPanel.TabIndex = 10;
            // 
            // NoToDosLabel
            // 
            this.NoToDosLabel.BackColor = System.Drawing.SystemColors.Window;
            this.NoToDosLabel.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.NoToDosLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NoToDosLabel.Location = new System.Drawing.Point(3, 27);
            this.NoToDosLabel.Name = "NoToDosLabel";
            this.NoToDosLabel.Size = new System.Drawing.Size(306, 143);
            this.NoToDosLabel.TabIndex = 6;
            this.NoToDosLabel.Text = "No To-Dos";
            this.NoToDosLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NoToDosLabel.Visible = false;
            // 
            // ToDoListDeleteItemButton
            // 
            this.ToDoListDeleteItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(242)))));
            this.ToDoListDeleteItemButton.BackgroundImage = global::FacebookUI.Properties.Resources.DeleteIcon;
            this.ToDoListDeleteItemButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ToDoListDeleteItemButton.FlatAppearance.BorderSize = 0;
            this.ToDoListDeleteItemButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(242)))));
            this.ToDoListDeleteItemButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.ToDoListDeleteItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToDoListDeleteItemButton.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDoListDeleteItemButton.ForeColor = System.Drawing.Color.White;
            this.ToDoListDeleteItemButton.Location = new System.Drawing.Point(252, 0);
            this.ToDoListDeleteItemButton.Margin = new System.Windows.Forms.Padding(0);
            this.ToDoListDeleteItemButton.Name = "ToDoListDeleteItemButton";
            this.ToDoListDeleteItemButton.Size = new System.Drawing.Size(27, 27);
            this.ToDoListDeleteItemButton.TabIndex = 8;
            this.ToDoListDeleteItemButton.UseVisualStyleBackColor = false;
            this.ToDoListDeleteItemButton.Click += new System.EventHandler(this.ToDoListDeleteItemButton_Click);
            // 
            // ToDoListAddItemButton
            // 
            this.ToDoListAddItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(242)))));
            this.ToDoListAddItemButton.BackgroundImage = global::FacebookUI.Properties.Resources.AddIcon;
            this.ToDoListAddItemButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ToDoListAddItemButton.FlatAppearance.BorderSize = 0;
            this.ToDoListAddItemButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(242)))));
            this.ToDoListAddItemButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.ToDoListAddItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToDoListAddItemButton.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDoListAddItemButton.ForeColor = System.Drawing.Color.White;
            this.ToDoListAddItemButton.Location = new System.Drawing.Point(282, 0);
            this.ToDoListAddItemButton.Margin = new System.Windows.Forms.Padding(0);
            this.ToDoListAddItemButton.Name = "ToDoListAddItemButton";
            this.ToDoListAddItemButton.Size = new System.Drawing.Size(27, 27);
            this.ToDoListAddItemButton.TabIndex = 7;
            this.ToDoListAddItemButton.UseVisualStyleBackColor = false;
            this.ToDoListAddItemButton.Click += new System.EventHandler(this.ToDoListAddItemButton_Click);
            // 
            // TodayToDoLabel
            // 
            this.TodayToDoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(242)))));
            this.TodayToDoLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TodayToDoLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TodayToDoLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TodayToDoLabel.ForeColor = System.Drawing.Color.White;
            this.TodayToDoLabel.Location = new System.Drawing.Point(0, 0);
            this.TodayToDoLabel.Name = "TodayToDoLabel";
            this.TodayToDoLabel.Size = new System.Drawing.Size(312, 27);
            this.TodayToDoLabel.TabIndex = 2;
            this.TodayToDoLabel.Text = "To-Do";
            this.TodayToDoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TodayToDoList
            // 
            this.TodayToDoList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TodayToDoList.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodayToDoList.FormattingEnabled = true;
            this.TodayToDoList.IntegralHeight = false;
            this.TodayToDoList.ItemHeight = 15;
            this.TodayToDoList.Location = new System.Drawing.Point(3, 27);
            this.TodayToDoList.Name = "TodayToDoList";
            this.TodayToDoList.Size = new System.Drawing.Size(306, 143);
            this.TodayToDoList.TabIndex = 1;
            this.TodayToDoList.SelectedIndexChanged += new System.EventHandler(this.TodayToDoList_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.NoEventsLabel);
            this.panel1.Controls.Add(this.EventsLabel);
            this.panel1.Controls.Add(this.EventsDataGrid);
            this.panel1.Location = new System.Drawing.Point(12, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 224);
            this.panel1.TabIndex = 11;
            // 
            // NoEventsLabel
            // 
            this.NoEventsLabel.BackColor = System.Drawing.SystemColors.Window;
            this.NoEventsLabel.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.NoEventsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NoEventsLabel.Location = new System.Drawing.Point(3, 46);
            this.NoEventsLabel.Name = "NoEventsLabel";
            this.NoEventsLabel.Size = new System.Drawing.Size(393, 175);
            this.NoEventsLabel.TabIndex = 5;
            this.NoEventsLabel.Text = "No Events";
            this.NoEventsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NoEventsLabel.Visible = false;
            // 
            // EventsLabel
            // 
            this.EventsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(120)))), ((int)(((byte)(242)))));
            this.EventsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EventsLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.EventsLabel.ForeColor = System.Drawing.Color.White;
            this.EventsLabel.Location = new System.Drawing.Point(0, 0);
            this.EventsLabel.Name = "EventsLabel";
            this.EventsLabel.Size = new System.Drawing.Size(399, 27);
            this.EventsLabel.TabIndex = 2;
            this.EventsLabel.Text = "Events";
            this.EventsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // daySummariesDictionaryBindingSource
            // 
            this.daySummariesDictionaryBindingSource.DataSource = typeof(System.Collections.Generic.KeyValuePair<System.DateTime, string>);
            // 
            // EventDetailsPanel
            // 
            this.EventDetailsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.EventDetailsPanel.Controls.Add(this.EventTicketsLinkLabel);
            this.EventDetailsPanel.Controls.Add(this.EventLocationLabel);
            this.EventDetailsPanel.Controls.Add(this.EventOwnerLabel);
            this.EventDetailsPanel.Controls.Add(this.EventEndTimeLabel);
            this.EventDetailsPanel.Controls.Add(this.EventStartTimeLabel);
            this.EventDetailsPanel.Controls.Add(this.label5);
            this.EventDetailsPanel.Controls.Add(this.label3);
            this.EventDetailsPanel.Controls.Add(this.label2);
            this.EventDetailsPanel.Controls.Add(this.label1);
            this.EventDetailsPanel.Controls.Add(this.EventCoverPicture);
            this.EventDetailsPanel.Controls.Add(this.label4);
            this.EventDetailsPanel.Location = new System.Drawing.Point(12, 306);
            this.EventDetailsPanel.Name = "EventDetailsPanel";
            this.EventDetailsPanel.Size = new System.Drawing.Size(643, 139);
            this.EventDetailsPanel.TabIndex = 12;
            // 
            // EventTicketsLinkLabel
            // 
            this.EventTicketsLinkLabel.AutoSize = true;
            this.EventTicketsLinkLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.EventTicketsLinkLabel.Location = new System.Drawing.Point(336, 103);
            this.EventTicketsLinkLabel.Name = "EventTicketsLinkLabel";
            this.EventTicketsLinkLabel.Size = new System.Drawing.Size(77, 16);
            this.EventTicketsLinkLabel.TabIndex = 10;
            this.EventTicketsLinkLabel.TabStop = true;
            this.EventTicketsLinkLabel.Text = "Buy Tickets";
            this.EventTicketsLinkLabel.Click += new System.EventHandler(this.EventTicketsLinkLabel_Click);
            // 
            // EventLocationLabel
            // 
            this.EventLocationLabel.AutoSize = true;
            this.EventLocationLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.EventLocationLabel.Location = new System.Drawing.Point(343, 69);
            this.EventLocationLabel.Name = "EventLocationLabel";
            this.EventLocationLabel.Size = new System.Drawing.Size(12, 16);
            this.EventLocationLabel.TabIndex = 9;
            this.EventLocationLabel.Text = "-";
            // 
            // EventOwnerLabel
            // 
            this.EventOwnerLabel.AutoSize = true;
            this.EventOwnerLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.EventOwnerLabel.Location = new System.Drawing.Point(331, 39);
            this.EventOwnerLabel.Name = "EventOwnerLabel";
            this.EventOwnerLabel.Size = new System.Drawing.Size(12, 16);
            this.EventOwnerLabel.TabIndex = 8;
            this.EventOwnerLabel.Text = "-";
            // 
            // EventEndTimeLabel
            // 
            this.EventEndTimeLabel.AutoSize = true;
            this.EventEndTimeLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.EventEndTimeLabel.Location = new System.Drawing.Point(513, 9);
            this.EventEndTimeLabel.Name = "EventEndTimeLabel";
            this.EventEndTimeLabel.Size = new System.Drawing.Size(12, 16);
            this.EventEndTimeLabel.TabIndex = 7;
            this.EventEndTimeLabel.Text = "-";
            // 
            // EventStartTimeLabel
            // 
            this.EventStartTimeLabel.AutoSize = true;
            this.EventStartTimeLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.EventStartTimeLabel.Location = new System.Drawing.Point(354, 9);
            this.EventStartTimeLabel.Name = "EventStartTimeLabel";
            this.EventStartTimeLabel.Size = new System.Drawing.Size(12, 16);
            this.EventStartTimeLabel.TabIndex = 6;
            this.EventStartTimeLabel.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(276, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tickets:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(276, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Location:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(440, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "End Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(276, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Time:";
            // 
            // EventCoverPicture
            // 
            this.EventCoverPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EventCoverPicture.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.eventBindingSource, "ImageLarge", true));
            this.EventCoverPicture.Location = new System.Drawing.Point(0, 0);
            this.EventCoverPicture.Name = "EventCoverPicture";
            this.EventCoverPicture.Size = new System.Drawing.Size(268, 139);
            this.EventCoverPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EventCoverPicture.TabIndex = 4;
            this.EventCoverPicture.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(276, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Owner:";
            // 
            // EventName
            // 
            this.EventName.DataPropertyName = "Name";
            this.EventName.HeaderText = "Name";
            this.EventName.Name = "EventName";
            this.EventName.ReadOnly = true;
            this.EventName.Width = 323;
            // 
            // EventLink
            // 
            this.EventLink.DataPropertyName = "LinkToFacebook";
            this.EventLink.HeaderText = "Link";
            this.EventLink.MinimumWidth = 50;
            this.EventLink.Name = "EventLink";
            this.EventLink.ReadOnly = true;
            this.EventLink.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EventLink.Text = "Link";
            this.EventLink.Width = 70;
            // 
            // MyDiaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(667, 640);
            this.Controls.Add(this.EventDetailsPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FriendsListPanel);
            this.Controls.Add(this.QuotesPanel);
            this.Controls.Add(this.MonthCalendar);
            this.Controls.Add(this.LoginBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MyDiaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Diary";
            this.LoginBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacebookLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            this.QuotesPanel.ResumeLayout(false);
            this.FriendsListPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.daySummariesDictionaryBindingSource)).EndInit();
            this.EventDetailsPanel.ResumeLayout(false);
            this.EventDetailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EventCoverPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoginBar;
        private System.Windows.Forms.PictureBox ProfilePictureBox;
        private System.Windows.Forms.PictureBox FacebookLogo;
        private System.Windows.Forms.MonthCalendar MonthCalendar;
        private System.Windows.Forms.DataGridView EventsDataGrid;
        private System.Windows.Forms.Panel QuotesPanel;
        private System.Windows.Forms.Label DaySummaryAreaLabel;
        private System.Windows.Forms.Label DaySummaryLabel;
        private System.Windows.Forms.Panel FriendsListPanel;
        private System.Windows.Forms.Label TodayToDoLabel;
        private System.Windows.Forms.ListBox TodayToDoList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label EventsLabel;
        private System.Windows.Forms.Button ToDoListAddItemButton;
        private System.Windows.Forms.Button ToDoListDeleteItemButton;
        private System.Windows.Forms.Button EditDaySummaryButton;
        private System.Windows.Forms.Label NoEventsLabel;
        private System.Windows.Forms.Label NoDaySummaryLabel;
        private System.Windows.Forms.Label NoToDosLabel;
        private BindingSource daySummariesDictionaryBindingSource;
        private BindingSource eventBindingSource;
        private Panel EventDetailsPanel;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox EventCoverPicture;
        private Label label4;
        private Label label5;
        private Label EventStartTimeLabel;
        private LinkLabel EventTicketsLinkLabel;
        private Label EventLocationLabel;
        private Label EventOwnerLabel;
        private Label EventEndTimeLabel;
        private DataGridViewTextBoxColumn EventName;
        private DataGridViewLinkColumn EventLink;
    }
}