using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookLogic;
using FacebookWrapper;
using Facebook;

namespace FacebookUI
{
    public partial class MainApp : Form
    {
        private const string k_Watermark = "What's on your mind?";
        private readonly MainAppFacade r_MainAppFacade;
        private readonly Color r_WatermarkColor = Color.FromArgb(101, 103, 107);
        private readonly LoginForm r_LoginForm;

        public MainApp(LoginForm i_LoginForm)
        {
            r_MainAppFacade = MainAppFacade.Instance;
            r_LoginForm = i_LoginForm;
            r_LoginForm.Visible = false;
            InitializeComponent();
        }

        private void MainApp_Load(object sender, EventArgs e)
        {
            new Thread(loadUserData).Start();
        }

        private void loadUserData()
        {
            loadFriends();
            loadGroups();
            loadInspiredPeople();
            loadLikedPages();
            loadAlbums();
            loadQuotes();
            LoadProfilePicture(ProfilePictureBox, r_MainAppFacade);
        }

        public static void LoadProfilePicture(PictureBox i_ProfilePictureBox, MainAppFacade i_MainAppFacade)
        {
            string profilePictureUrl = i_MainAppFacade.FetchSmallProfilePictureUrl();

            if(!string.IsNullOrEmpty(profilePictureUrl))
            {
                i_ProfilePictureBox.ImageLocation = profilePictureUrl;
            }
            else
            {
                MessageBox.Show("Failed to fetch profile picture.");
            }
        }

        private void loadFriends()
        {
            try
            {
                List<string> friends = r_MainAppFacade.FetchFriends();

                foreach(string friendName in friends)
                {
                        FriendsList.Items.Add(friendName);
                }

                FriendsListLabel.Text = $"Friends ({friends.Count})";
            }
            catch(Exception exception)
            {
                FriendsList.Items.Add(exception.Message);
            }
        }

        private void loadLikedPages()
        {
            try
            {
                List<string> likedPages = r_MainAppFacade.FetchLikedPages();

                foreach(string likedPage in likedPages)
                {
                    LikedPagesList.Items.Add(likedPage);
                }

                LikedPagesLabel.Text = $"Liked Pages ({likedPages.Count})";
            }
            catch (Exception exception)
            {
                LikedPagesList.Items.Add(exception.Message);
            }
        }

        private void loadAlbums()
        {
            try
            {
                List<string> albums = r_MainAppFacade.FetchAlbums();

                foreach(string album in albums)
                {
                    if(album != null)
                    {
                        AlbumsList.Items.Add(album);
                    }
                }

                AlbumsLabel.Text = $"Albums ({albums.Count})";
            }
            catch (Exception exception)
            {
                AlbumsList.Items.Add(exception.Message);
            }
        }

        private void loadInspiredPeople()
        {
            try
            {
                List<string> inspiredPeople = r_MainAppFacade.FetchInspiredPeople();

                foreach(string inspiredPerson in inspiredPeople)
                {
                    if(inspiredPerson != null)
                    {
                        InspiredPeopleList.Items.Add(inspiredPerson);
                    }
                }

                InspiredPeopleLabel.Text = $"Inspired People ({inspiredPeople.Count})";
            }
            catch (Exception exception)
            {
                InspiredPeopleList.Items.Add(exception.Message);
            }
        }

        private void loadQuotes()
        {
            string quotes = r_MainAppFacade.FetchQuotes();
            QuotesAreaLabel.Text = (!string.IsNullOrEmpty(quotes)) ? quotes : "No quotes found.";
        }

        private void loadGroups()
        {
            try
            {
                List<string> groups = r_MainAppFacade.FetchGroups();

                foreach(string group in groups)
                {
                    if(group != null)
                    {
                        GroupsList.Items.Add(group);
                    }
                }

                GroupsLabel.Text = $"Groups ({groups.Count})";
            }
            catch (Exception exception)
            {
                GroupsList.Items.Add(exception.Message);
            }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            r_MainAppFacade.Logout();
            r_LoginForm.Visible = true;
            Close();
        }

        private void PostTextBox_Leave(object sender, EventArgs e)
        {
            if(PostTextBox.Text.Length == 0 || PostTextBox.ForeColor == r_WatermarkColor)
            {
                PostTextBox.Text = k_Watermark;
                PostTextBox.ForeColor = r_WatermarkColor;
            }
        }

        private void PostTextBox_Enter(object sender, EventArgs e)
        {
            if(PostTextBox.ForeColor == r_WatermarkColor)
            {
                PostTextBox.Text = string.Empty;
                PostTextBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void PostButton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(PostTextBox.Text) && PostTextBox.ForeColor != r_WatermarkColor)
            {
                try
                {
                    r_MainAppFacade.PostStatus(PostTextBox.Text);
                }
                catch(Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }

            PostTextBox.Text = k_Watermark;
            PostTextBox.ForeColor = r_WatermarkColor;
        }

        private void FriendsDiagnosticsButton_Click(object sender, EventArgs e)
        {
            new FriendsDiagnosticsForm().ShowDialog();
        }

        private void MyDiaryButton_Click(object sender, EventArgs e)
        {
            new MyDiaryForm().ShowDialog();
        }
    }
}