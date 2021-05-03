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
    public partial class FriendsDiagnosticsForm : Form
    {
        private readonly AppLogic r_AppLogic;
        private readonly FriendsDiagnosticsLogic r_FriendsDiagnosticsLogic;
        private string m_SelectedFriendUrl;

        public FriendsDiagnosticsForm(AppLogic i_AppLogic)
        {
            r_AppLogic = i_AppLogic;
            r_FriendsDiagnosticsLogic = new FriendsDiagnosticsLogic();
            InitializeComponent();
            FriendProfileLink.Visible = false;
            MainApp.LoadProfilePicture(ProfilePictureBox, r_AppLogic);
        }

        private void GenderFilterButton_Click(object sender, EventArgs e)
        {
            r_FriendsDiagnosticsLogic.FilterParameterSelectedValue = null;

            try
            {
                new GenderChoiceForm(r_FriendsDiagnosticsLogic).ShowDialog();

                if(!string.IsNullOrEmpty(r_FriendsDiagnosticsLogic.FilterParameterSelectedValue))
                {
                    r_FriendsDiagnosticsLogic.FilterFriendsByParameter(r_AppLogic, eFilterParameters.Gender);
                    Dictionary<string, string> friendsFilterResults =
                        r_FriendsDiagnosticsLogic.FilterResultsIdAndNameDictionary;
                    loadFilterResults(friendsFilterResults);   
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void loadFilterResults(Dictionary<string, string> i_FriendsFilterResults)
        {
            FriendsFilterResultsList.Items.Clear();
            FriendProfilePictureBox.ImageLocation = null;
            FriendProfileLink.Visible = false;

            foreach (string friendName in i_FriendsFilterResults.Values)
            {
                FriendsFilterResultsList.Items.Add(friendName);
            }
        }

        private void BirthyearFilterButton_Click(object sender, EventArgs e)
        {
            r_FriendsDiagnosticsLogic.FilterParameterSelectedValue = null;

            try
            {
                new BirthyearInputForm(r_FriendsDiagnosticsLogic).ShowDialog();

                if (!string.IsNullOrEmpty(r_FriendsDiagnosticsLogic.FilterParameterSelectedValue))
                {
                    r_FriendsDiagnosticsLogic.FilterFriendsByParameter(r_AppLogic, eFilterParameters.Birthyear);
                    Dictionary<string, string> friendsFilterResults =
                        r_FriendsDiagnosticsLogic.FilterResultsIdAndNameDictionary;
                    loadFilterResults(friendsFilterResults);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void CityFilterButton_Click(object sender, EventArgs e)
        {
            r_FriendsDiagnosticsLogic.FilterParameterSelectedValue = null;

            try
            {
                new CityInputForm(r_FriendsDiagnosticsLogic).ShowDialog();

                if (!string.IsNullOrEmpty(r_FriendsDiagnosticsLogic.FilterParameterSelectedValue))
                {
                    r_FriendsDiagnosticsLogic.FilterFriendsByParameter(r_AppLogic, eFilterParameters.City);
                    Dictionary<string, string> friendsFilterResults =
                        r_FriendsDiagnosticsLogic.FilterResultsIdAndNameDictionary;
                    loadFilterResults(friendsFilterResults);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void MutualArtistsFilterButton_Click(object sender, EventArgs e)
        {
            try
            {
                r_FriendsDiagnosticsLogic.FilterFriendsByParameter(r_AppLogic, eFilterParameters.MutualArtists);
                Dictionary<string, string> friendsFilterResults =
                    r_FriendsDiagnosticsLogic.FilterResultsIdAndNameDictionary;
                loadFilterResults(friendsFilterResults);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void MutualLikedPagesFilterButton_Click(object sender, EventArgs e)
        {
            try
            {
                r_FriendsDiagnosticsLogic.FilterFriendsByParameter(r_AppLogic, eFilterParameters.MutualPages);
                Dictionary<string, string> friendsFilterResults =
                    r_FriendsDiagnosticsLogic.FilterResultsIdAndNameDictionary;
                loadFilterResults(friendsFilterResults);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void MutualGroupsFilterButton_Click(object sender, EventArgs e)
        {
            try
            {
                r_FriendsDiagnosticsLogic.FilterFriendsByParameter(r_AppLogic, eFilterParameters.MutualGroups);
                Dictionary<string, string> friendsFilterResults =
                    r_FriendsDiagnosticsLogic.FilterResultsIdAndNameDictionary;
                loadFilterResults(friendsFilterResults);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void FriendsFilterResultsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = FriendsFilterResultsList.SelectedIndex;

            if (FriendsFilterResultsList.Items.Count != 0)
            {
                string friendId =
                    r_FriendsDiagnosticsLogic.FilterResultsIdAndNameDictionary.Keys.ElementAt(selectedIndex);
                FriendProfileLink.Visible = true;
                FriendProfilePictureBox.ImageLocation = r_AppLogic.FetchFriendProfilePictureUrl(friendId);
                m_SelectedFriendUrl = r_AppLogic.FetchFriendProfileUrl(friendId);
            }
        }

        private void FriendsFilterResultsList_Leave(object sender, EventArgs e)
        {
            if(FriendsFilterResultsList.SelectedItem == null)
            {
                FriendProfilePictureBox.ImageLocation = null;
                FriendProfileLink.Visible = false;
            }
        }

        private void FriendProfileLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(m_SelectedFriendUrl);
        }
    }
}
