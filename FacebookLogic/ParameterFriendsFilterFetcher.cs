using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    public abstract class ParameterFriendsFilterFetcher
    {
        private const string k_EmptyFriendsListError = "You have an empty friends list.";
        private const string k_PermissionsError = "Insufficient permissions for this action.";

        public FacebookObjectCollection<User> FilterByParameter(object i_Object)
        {
            FacebookObjectCollection<User> friends = AppLogic.Instance.LoggedInUser.Friends;
            FacebookObjectCollection<User> filterResults = new FacebookObjectCollection<User>();

            try
            {
                foreach (User friend in friends)
                {
                    try
                    {
                        if (ShouldAdd(friend, i_Object))
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

        protected abstract bool ShouldAdd(User i_Friend, object i_Object);
    }
}