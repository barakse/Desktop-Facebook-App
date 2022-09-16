using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    public class GenderFilterLogic
    {
        private const string k_EmptyFriendsListError = "You have an empty friends list.";
        private const string k_PermissionsError = "Insufficient permissions for this action.";
        private readonly AppLogic r_AppLogic;

        public GenderFilterLogic()
        {
            r_AppLogic = AppLogic.Instance;
        }

        public FacebookObjectCollection<User> FilterByGender(string i_GenderType)
        {
            User.eGender selectedGender = i_GenderType == "Male" ? User.eGender.male : User.eGender.female;
            FacebookObjectCollection<User> friends = r_AppLogic.LoggedInUser.Friends;
            FacebookObjectCollection<User> filterResults = new FacebookObjectCollection<User>();

            try
            {
                foreach (User friend in friends)
                {
                    if (friend.Gender == selectedGender)
                    {
                        filterResults.Add(friend);
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