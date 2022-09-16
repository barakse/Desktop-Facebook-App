using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    public class CityFilterLogic
    {
        private const string k_EmptyFriendsListError = "You have an empty friends list.";
        private const string k_PermissionsError = "Insufficient permissions for this action.";
        private readonly AppLogic r_AppLogic;

        public CityFilterLogic()
        {
            r_AppLogic = AppLogic.Instance;
        }

        public FacebookObjectCollection<User> FilterByCity(string i_City)
        {
            FacebookObjectCollection<User> friends = r_AppLogic.LoggedInUser.Friends;
            FacebookObjectCollection<User> filterResults = new FacebookObjectCollection<User>();

            try
            {
                foreach (User friend in friends)
                {
                    if (friend.Location != null)
                    {
                        if (friend.Location.Name == i_City)
                        {
                            filterResults.Add(friend);
                        }
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
