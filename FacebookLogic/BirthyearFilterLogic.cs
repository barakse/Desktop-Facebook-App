using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    public class BirthyearFilterLogic
    {
        private const string k_EmptyFriendsListError = "You have an empty friends list.";
        private const string k_PermissionsError = "Insufficient permissions for this action.";
        private readonly AppLogic r_AppLogic;

        public BirthyearFilterLogic()
        {
            r_AppLogic = AppLogic.Instance;
        }

        public FacebookObjectCollection<User> FilterByBirthyear(string i_BirthYear)
        {
            FacebookObjectCollection<User> friends = r_AppLogic.LoggedInUser.Friends;
            FacebookObjectCollection<User> filterResults = new FacebookObjectCollection<User>();

            try
            {
                foreach (User friend in friends)
                {
                    try
                    {
                        if (friend.Birthday.Substring(6) == i_BirthYear)
                        {
                            filterResults.Add(friend);
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
                if (friends.Count == 0)
                {
                    throw new Exception(k_EmptyFriendsListError);
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
