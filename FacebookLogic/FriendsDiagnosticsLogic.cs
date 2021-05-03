using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    public class FriendsDiagnosticsLogic
    {
        private const string k_PermissionsError = "Insufficient permissions for this action.";
        private const string k_EmptyGroupsListError = "You have an empty groups list.";
        private const string k_EmptyArtistsListError = "You have an empty artists list.";
        private const string k_EmptyLikedPagesListError = "You have an empty liked pages list.";
        private const string k_EmptyFriendsListError = "You have an empty friends list.";

        public string FilterParameterSelectedValue { get; set; }

        private readonly Dictionary<string, string> r_FilterResultsIdAndNameDictionary = new Dictionary<string, string>();

        public Dictionary<string, string> FilterResultsIdAndNameDictionary
        {
            get
            {
                return r_FilterResultsIdAndNameDictionary;
            }
        }

        public void FilterFriendsByParameter(AppLogic i_AppLogic, eFilterParameters i_SelectedParameterIndex)
        {
            try
            {
                r_FilterResultsIdAndNameDictionary.Clear();

                switch(i_SelectedParameterIndex)
                {
                    case eFilterParameters.Gender:
                        {
                            filterByGender(i_AppLogic.LoggedInUser);
                            break;
                        }

                    case eFilterParameters.Birthyear:
                        {
                            filterByBirthyear(i_AppLogic.LoggedInUser);
                            break;
                        }

                    case eFilterParameters.City:
                        {
                            filterByCity(i_AppLogic.LoggedInUser);
                            break;
                        }

                    case eFilterParameters.MutualArtists:
                        {
                            filterByMutualArtists(i_AppLogic);
                            break;
                        }

                    case eFilterParameters.MutualPages:
                        {
                            filterByMutualLikedPages(i_AppLogic);
                            break;
                        }

                    case eFilterParameters.MutualGroups:
                        {
                            filterByMutualGroups(i_AppLogic);
                            break;
                        }
                }
            }
            catch(Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        private void filterByGender(User i_LoggedInUser)
        {
            User.eGender selectedGender =
                FilterParameterSelectedValue == "Male" ? User.eGender.male : User.eGender.female;

            try
            {
                foreach(User friend in i_LoggedInUser.Friends)
                {
                    if(friend.Gender == selectedGender)
                    {
                        r_FilterResultsIdAndNameDictionary.Add(friend.Id, friend.Name);
                    }
                }
            }
            catch
            {
                if(i_LoggedInUser.Friends.Count == 0)
                {
                    throw new Exception(k_EmptyFriendsListError);
                }
                else
                {
                    throw new Exception(k_PermissionsError);
                }
            }
        }

        private void filterByMutualGroups(AppLogic i_AppLogic)
        {
            List<string> userGroupsList = i_AppLogic.FetchGroupsList(i_AppLogic.LoggedInUser.Id);

            try
            {
                foreach (User friend in i_AppLogic.LoggedInUser.Friends)
                {
                    bool isMutualGroupFound = false;

                    try
                    {
                        List<string> friendGroupsList = i_AppLogic.FetchGroupsList(friend.Id);
                        foreach(string userGroup in userGroupsList)
                        {
                            foreach(string friendGroup in friendGroupsList)
                            {
                                if(userGroup == friendGroup)
                                {
                                    r_FilterResultsIdAndNameDictionary.Add(friend.Id, friend.Name);
                                    isMutualGroupFound = true;
                                    break;
                                }
                            }

                            if(isMutualGroupFound == true)
                            {
                                break;
                            }
                        }
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
            catch
            {
                if (i_AppLogic.LoggedInUser.Friends.Count == 0)
                {
                    throw new Exception(k_EmptyFriendsListError);
                }
                else if(userGroupsList.Count == 0)
                {
                    throw new Exception(k_EmptyGroupsListError);
                }
                else
                {
                    throw new Exception(k_PermissionsError);
                }
            }
        }

        private void filterByMutualLikedPages(AppLogic i_AppLogic)
        {
            List<string> userLikedPagesList = i_AppLogic.FetchLikedPagesList(i_AppLogic.LoggedInUser.Id);

            try
            {
                foreach (User friend in i_AppLogic.LoggedInUser.Friends)
                {
                    bool isMutualLikedPageFound = false;

                    try
                    {
                        List<string> friendLikedPagesList = i_AppLogic.FetchLikedPagesList(friend.Id);
                        foreach (string userLikedPage in userLikedPagesList)
                        {
                            foreach (string friendLikedPage in friendLikedPagesList)
                            {
                                if (userLikedPage == friendLikedPage)
                                {
                                    r_FilterResultsIdAndNameDictionary.Add(friend.Id, friend.Name);
                                    isMutualLikedPageFound = true;
                                    break;
                                }
                            }

                            if (isMutualLikedPageFound == true)
                            {
                                break;
                            }
                        }
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
            catch
            {
                if (i_AppLogic.LoggedInUser.Friends.Count == 0)
                {
                    throw new Exception(k_EmptyFriendsListError);
                }
                else if (userLikedPagesList.Count == 0)
                {
                    throw new Exception(k_EmptyArtistsListError);
                }
                else
                {
                    throw new Exception(k_PermissionsError);
                }
            }
        }

        private void filterByMutualArtists(AppLogic i_AppLogic)
        {
            List<string> userArtistsList = i_AppLogic.FetchArtistsList(i_AppLogic.LoggedInUser.Id);

            try
            {
                foreach (User friend in i_AppLogic.LoggedInUser.Friends)
                {
                    bool isMutualArtistFound = false;

                    try
                    {
                        List<string> friendArtistsList = i_AppLogic.FetchArtistsList(friend.Id);
                        foreach (string userArtist in userArtistsList)
                        {
                            foreach (string friendArtist in friendArtistsList)
                            {
                                if (userArtist == friendArtist)
                                {
                                    r_FilterResultsIdAndNameDictionary.Add(friend.Id, friend.Name);
                                    isMutualArtistFound = true;
                                    break;
                                }
                            }

                            if (isMutualArtistFound == true)
                            {
                                break;
                            }
                        }
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
            catch
            {
                if (i_AppLogic.LoggedInUser.Friends.Count == 0)
                {
                    throw new Exception(k_EmptyFriendsListError);
                }
                else if (userArtistsList.Count == 0)
                {
                    throw new Exception(k_EmptyArtistsListError);
                }
                else
                {
                    throw new Exception(k_PermissionsError);
                }
            }
        }

        private void filterByCity(User i_LoggedInUser)
        {
            try
            {
                foreach (User friend in i_LoggedInUser.Friends)
                {
                    if(friend.Location != null)
                    {
                        if(friend.Location.Name == FilterParameterSelectedValue)
                        {
                            r_FilterResultsIdAndNameDictionary.Add(friend.Id, friend.Name);
                        }
                    }
                }
            }
            catch
            {
                if (i_LoggedInUser.Friends.Count == 0)
                {
                    throw new Exception(k_EmptyFriendsListError);
                }
                else
                {
                    throw new Exception(k_PermissionsError);
                }
            }
        }

        private void filterByBirthyear(User i_LoggedInUser)
        {
            try
            {
                foreach (User friend in i_LoggedInUser.Friends)
                {
                    if (friend.Birthday.Substring(6) == FilterParameterSelectedValue)
                    {
                        r_FilterResultsIdAndNameDictionary.Add(friend.Id, friend.Name);
                    }
                }
            }
            catch
            {
                if (i_LoggedInUser.Friends.Count == 0)
                {
                    throw new Exception(k_EmptyFriendsListError);
                }
                else
                {
                    throw new Exception(k_PermissionsError);
                }
            }
        }
    }
}