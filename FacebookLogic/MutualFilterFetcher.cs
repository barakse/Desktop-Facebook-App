using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    public class MutualFilterFetcher
    {
        private const string k_PermissionsError = "Insufficient permissions for this action.";
        private const string k_EmptyFriendsListError = "You have an empty friends list.";
        private readonly string r_EmptyFilterCollectionError;
        private readonly AppLogic r_AppLogic;

        public IMutualFilterStrategy MutualFilterStrategy { get; set; }

        public MutualFilterFetcher(IMutualFilterStrategy i_MutualFilterStrategy, string i_EmptyFilterCollectionError)
        {
            MutualFilterStrategy = i_MutualFilterStrategy;
            r_EmptyFilterCollectionError = i_EmptyFilterCollectionError;
            r_AppLogic = AppLogic.Instance;
        }

        public FacebookObjectCollection<User> FilterByMutual()
        {
            List<string> userGeneralCollectionList = MutualFilterStrategy.FetchUserCollectionToScan(r_AppLogic.LoggedInUser.Id);
            FacebookObjectCollection<User> friends = r_AppLogic.LoggedInUser.Friends;
            FacebookObjectCollection<User> filterResults = new FacebookObjectCollection<User>();

            try
            {
                foreach (User friend in friends)
                {
                    bool isMutualFound = false;

                    try
                    {
                        List<string> friendGeneralCollectionList = MutualFilterStrategy.FetchUserCollectionToScan(friend.Id);
                        foreach (string userGeneralCollectionString in userGeneralCollectionList)
                        {
                            foreach (string friendGeneralCollectionString in friendGeneralCollectionList)
                            {
                                if (userGeneralCollectionString == friendGeneralCollectionString)
                                {
                                    filterResults.Add(friend);
                                    isMutualFound = true;
                                    break;
                                }
                            }

                            if (isMutualFound == true)
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
                else if (userGeneralCollectionList.Count == 0)
                {
                    throw new Exception(r_EmptyFilterCollectionError);
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
