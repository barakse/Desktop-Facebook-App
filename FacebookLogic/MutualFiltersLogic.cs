using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    public class MutualFiltersLogic
    {
        private const string k_PermissionsError = "Insufficient permissions for this action.";
        private const string k_EmptyGroupsListError = "You have an empty groups list.";
        private const string k_EmptyArtistsListError = "You have an empty artists list.";
        private const string k_EmptyLikedPagesListError = "You have an empty liked pages list.";
        private const string k_EmptyFriendsListError = "You have an empty friends list.";
        private readonly AppLogic r_AppLogic;

        public MutualFiltersLogic()
        {
            r_AppLogic = AppLogic.Instance;
        }

        public FacebookObjectCollection<User> FilterByMutualGroups()
        {
            List<string> userGroupsList = r_AppLogic.FetchGroupsList(r_AppLogic.LoggedInUser.Id);
            FacebookObjectCollection<User> friends = r_AppLogic.LoggedInUser.Friends;
            FacebookObjectCollection<User> filterResults = new FacebookObjectCollection<User>();

            try
            {
                foreach (User friend in friends)
                {
                    bool isMutualGroupFound = false;

                    try
                    {
                        List<string> friendGroupsList = r_AppLogic.FetchGroupsList(friend.Id);
                        foreach (string userGroup in userGroupsList)
                        {
                            foreach (string friendGroup in friendGroupsList)
                            {
                                if (userGroup == friendGroup)
                                {
                                    filterResults.Add(friend);
                                    isMutualGroupFound = true;
                                    break;
                                }
                            }

                            if (isMutualGroupFound == true)
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
                if (r_AppLogic.LoggedInUser.Friends.Count == 0)
                {
                    throw new Exception(k_EmptyFriendsListError);
                }
                else if (userGroupsList.Count == 0)
                {
                    throw new Exception(k_EmptyGroupsListError);
                }
                else
                {
                    throw new Exception(k_PermissionsError);
                }
            }

            return filterResults;
        }

        public FacebookObjectCollection<User> FilterByMutualLikedPages()
        {
            List<string> userLikedPagesList = r_AppLogic.FetchLikedPagesList(r_AppLogic.LoggedInUser.Id);
            FacebookObjectCollection<User> friends = r_AppLogic.LoggedInUser.Friends;
            FacebookObjectCollection<User> filterResults = new FacebookObjectCollection<User>();

            try
            {
                foreach (User friend in friends)
                {
                    bool isMutualLikedPageFound = false;

                    try
                    {
                        List<string> friendLikedPagesList = r_AppLogic.FetchLikedPagesList(friend.Id);
                        foreach (string userLikedPage in userLikedPagesList)
                        {
                            foreach (string friendLikedPage in friendLikedPagesList)
                            {
                                if (userLikedPage == friendLikedPage)
                                {
                                    filterResults.Add(friend);
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
                if (r_AppLogic.LoggedInUser.Friends.Count == 0)
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

            return filterResults;
        }

        public FacebookObjectCollection<User> FilterByMutualArtists()
        {
            List<string> userArtistsList = r_AppLogic.FetchArtistsList(r_AppLogic.LoggedInUser.Id);
            FacebookObjectCollection<User> friends = r_AppLogic.LoggedInUser.Friends;
            FacebookObjectCollection<User> filterResults = new FacebookObjectCollection<User>();

            try
            {
                foreach (User friend in friends)
                {
                    bool isMutualArtistFound = false;

                    try
                    {
                        List<string> friendArtistsList = r_AppLogic.FetchArtistsList(friend.Id);
                        foreach (string userArtist in userArtistsList)
                        {
                            foreach (string friendArtist in friendArtistsList)
                            {
                                if (userArtist == friendArtist)
                                {
                                    filterResults.Add(friend);
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
                if (r_AppLogic.LoggedInUser.Friends.Count == 0)
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

            return filterResults;
        }
    }
}