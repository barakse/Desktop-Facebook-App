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
using FacebookWrapper.ObjectModel;

namespace FacebookUI
{
    public partial class FriendsDiagnosticsForm : Form
    {
        private readonly MainAppFacade r_MainAppFacade;
        private readonly FiltersFacade r_FiltersFacade;
        private string m_SelectedFriendUrl;

        public FriendsDiagnosticsForm()
        {
            r_MainAppFacade = MainAppFacade.Instance;
            r_FiltersFacade = new FiltersFacade();
            InitializeComponent();
            FriendProfileLink.Visible = false;
            ProfilePictureBox.ImageLocation = r_MainAppFacade.FetchSmallProfilePictureUrl();
        }

        private void GenderFilterButton_Click(object sender, EventArgs e)
        {
            r_FiltersFacade.FilterParameterSelectedValue = null;

            try
            {
                new GenderChoiceForm(r_FiltersFacade).ShowDialog();

                if(!string.IsNullOrEmpty(r_FiltersFacade.FilterParameterSelectedValue))
                {
                    userBindingSource.DataSource = r_FiltersFacade.FilterByGender();
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void BirthyearFilterButton_Click(object sender, EventArgs e)
        {
            r_FiltersFacade.FilterParameterSelectedValue = null;

            try
            {
                new BirthyearInputForm(r_FiltersFacade).ShowDialog();

                if (!string.IsNullOrEmpty(r_FiltersFacade.FilterParameterSelectedValue))
                {
                    userBindingSource.DataSource = r_FiltersFacade.FilterByBirthyear();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void CityFilterButton_Click(object sender, EventArgs e)
        {
            r_FiltersFacade.FilterParameterSelectedValue = null;

            try
            {
                new CityInputForm(r_FiltersFacade).ShowDialog();

                if(!string.IsNullOrEmpty(r_FiltersFacade.FilterParameterSelectedValue))
                {
                    userBindingSource.DataSource = r_FiltersFacade.FilterByCity();
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void MutualArtistsFilterButton_Click(object sender, EventArgs e)
        {
            try
            {
                userBindingSource.DataSource = r_FiltersFacade.FilterByMutualArtists();
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
                userBindingSource.DataSource = r_FiltersFacade.FilterByMutualLikedPages();
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
                userBindingSource.DataSource = r_FiltersFacade.FilterByMutualGroups();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void FriendProfileLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(m_SelectedFriendUrl);
        }

        private void userBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            User currentSelectedUser = (sender as BindingSource).Current as User;

            if (currentSelectedUser != null)
            {
                FilterResultAdapter filterResultAdapter = new FilterResultAdapter(currentSelectedUser.Birthday);
                AgeLabel.Text = filterResultAdapter.GetAge();
                SignLabel.Text = filterResultAdapter.GetSign();
                FriendProfileLink.Visible = true;
                m_SelectedFriendUrl = currentSelectedUser.Link;
            }
            else
            {
                FriendProfileLink.Visible = false;
                AgeLabel.Text = "-";
                SignLabel.Text = "-";
            }
        }
    }
}
