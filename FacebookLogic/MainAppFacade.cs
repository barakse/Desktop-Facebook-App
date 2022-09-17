using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookLogic
{
    public sealed class MainAppFacade
    {
        private static readonly object sr_LockContext = new object();
        private static MainAppFacade s_Instance = null;
        private readonly AppLogic r_AppLogic;

        private MainAppFacade()
        {
            r_AppLogic = AppLogic.Instance;
        }

        public static MainAppFacade Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (sr_LockContext)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new MainAppFacade();
                        }
                    }
                }

                return s_Instance;
            }
        }

        public Dictionary<DateTime, string> DaySummariesDictionary
        {
            get
            {
                return r_AppLogic.DaySummariesDictionary;
            }

            set
            {
                r_AppLogic.DaySummariesDictionary = value;
            }
        }

        public List<string> FetchFriends()
        {
            return r_AppLogic.FetchFriendsList();
        }

        public string FetchSmallProfilePictureUrl()
        {
            return r_AppLogic.FetchSmallProfilePictureUrl();
        }

        public List<string> FetchLikedPages()
        {
            return r_AppLogic.FetchLikedPagesList();
        }

        public List<string> FetchAlbums()
        {
            return r_AppLogic.FetchAlbumsList();
        }

        public List<string> FetchInspiredPeople()
        {
            return r_AppLogic.FetchInspiredPeopleList();
        }

        public List<string> FetchArtists()
        {
            return r_AppLogic.FetchArtistsList();
        }

        public List<string> FetchGroups()
        {
            return r_AppLogic.FetchGroupsList();
        }

        public string FetchQuotes()
        {
            return r_AppLogic.FetchQuotes();
        }

        public void PostStatus(string i_StatusContent)
        {
            r_AppLogic.PostStatusOnWall(i_StatusContent);
        }

        public void AddOrChangeDaySummary(DateTime i_Date, string i_DaySummary)
        {
            r_AppLogic.AddOrChangeDaySummaryDictionaryValue(i_Date, i_DaySummary);
        }

        public void Login()
        {
            r_AppLogic.LoginAndInit();
        }

        public void Logout()
        {
            r_AppLogic.Logout();
        }
    }
}
