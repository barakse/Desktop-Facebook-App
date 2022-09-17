using System;
using System.Collections.Generic;
using System.Configuration;
using System.Dynamic;
using System.Reflection;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using Facebook;

namespace FacebookLogic
{
    public sealed class AppLogic
    {
        public User m_LoggedInUser;

        private const string k_FailedToPostError = "Failed to post the status, please try again.";
        private const string k_FriendsFetchError = "Failed to fetch friends.";
        private const string k_LikedPagesFetchError = "Failed to fetch liked pages.";
        private const string k_AlbumsFetchError = "Failed to fetch albums.";
        private const string k_InspiredPeopleFetchError = "Failed to fetch inspired people.";
        private const string k_ArtistsFetchError = "Failed to fetch artists.";
        private const string k_GroupsFetchError = "Failed to fetch groups.";
        private const string k_QuotesFetchError = "Failed to fetch quotes.";
        private const string k_AppId = "1142212852917702";
        private static readonly object sr_LockContext = new object();
        private static AppLogic s_Instance = null;
        private LoginResult m_LoginResult;

        public static AppLogic Instance
        {
            get
            {
                if(s_Instance == null)
                {
                    lock(sr_LockContext)
                    {
                        if(s_Instance == null)
                        {
                            s_Instance = new AppLogic();
                        }
                    }
                }

                return s_Instance;
            }
        }

        public Dictionary<DateTime, string> DaySummariesDictionary { get; set; }

        public Dictionary<DateTime, List<string>> UserToDoDictionary { get; set; }

        private AppLogic()
        {
            DaySummariesDictionary = new Dictionary<DateTime, string>();
            UserToDoDictionary = new Dictionary<DateTime, List<string>>();
            FacebookWrapper.FacebookService.s_CollectionLimit = 200;
        }

        public User LoggedInUser
        {
            get
            {
                return m_LoggedInUser;
            }
        }

        public void LoginAndInit()
        {
            m_LoginResult = FacebookService.Login(
                k_AppId,
                "public_profile",
                "email",
                "pages_show_list",
                "pages_read_engagement",
                "pages_manage_posts",
                "publish_to_groups",
                "user_birthday",
                "user_age_range",
                "user_gender",
                "user_link",
                "user_videos",
                "groups_access_member_info",
                "groups_show_list",
                "user_friends",
                "user_events",
                "user_likes",
                "user_location",
                "user_photos",
                "user_posts",
                "user_hometown");

            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;
            }
            else
            {
                throw new Exception("Login failed, please try again.");
            }
        }

        public void Logout()
        {
            FacebookService.Logout(null);
            DaySummariesDictionary.Clear();
            UserToDoDictionary.Clear();
            m_LoggedInUser = null;
        }

        public List<string> FetchFriendsList()
        {
            List<string> friendsList = new List<string>();

            try
            {
                foreach(User friend in m_LoggedInUser.Friends)
                {
                    friendsList.Add(friend.Name);
                }
            }
            catch
            {
                throw new Exception(k_FriendsFetchError);
            }

            return friendsList;
        }

        public string FetchSmallProfilePictureUrl()
        {
            return m_LoggedInUser.PictureSmallURL;
        }

        public string FetchFriendProfilePictureUrl(string i_UserId)
        {
            string profilePictureUrl = null;

            foreach(User friend in m_LoggedInUser.Friends)
            {
                if(friend.Id == i_UserId)
                {
                    profilePictureUrl = friend.PictureLargeURL;
                    break;
                }
            }

            return profilePictureUrl;
        }

        public string FetchFriendProfileUrl(string i_UserId)
        {
            string profileUrl = null;

            foreach (User friend in m_LoggedInUser.Friends)
            {
                if (friend.Id == i_UserId)
                {
                    profileUrl = friend.Link;
                    break;
                }
            }

            return profileUrl;
        }

        public List<string> FetchLikedPagesList(string i_UserID = "me")
        {
            FacebookClient client = new FacebookClient(m_LoginResult.AccessToken);
            JsonObject me = client.Get(i_UserID + "?fields=likes") as JsonObject;
            JsonObject likedPagesObject = me.Values.ElementAt(0) as JsonObject;
            JsonArray likedPages = likedPagesObject.Values.ElementAt(0) as JsonArray;
            List<string> likedPagesList = new List<string>();

            try
            {
                foreach (JsonObject likedPage in likedPages)
                {
                    likedPagesList.Add(likedPage.Values.ElementAt(0).ToString());
                }
            }
            catch
            {
                throw new Exception(k_LikedPagesFetchError);
            }

            return likedPagesList;
        }

        public List<string> FetchAlbumsList()
        {
            List<string> albumsList = new List<string>();

            try
            {
                foreach(Album album in m_LoggedInUser.Albums)
                {
                    albumsList.Add(album.Name);
                }
            }
            catch
            {
                throw new Exception(k_AlbumsFetchError);
            }

            return albumsList;
        }

        public string FetchQuotes()
        {
            try
            {
                return m_LoggedInUser.Quotes;
            }
            catch
            {
                throw new Exception(k_QuotesFetchError);
            }
        }

        public List<string> FetchInspiredPeopleList()
        {
            FacebookClient client = new FacebookClient(m_LoginResult.AccessToken);
            JsonObject me = client.Get("me?fields=inspirational_people") as JsonObject;
            JsonArray inspiredPeople = me.Values.ElementAt(0) as JsonArray;
            List<string> inspiredPeopleList = new List<string>();

            try
            {
                foreach(JsonObject inspiredPerson in inspiredPeople)
                {
                    inspiredPeopleList.Add(inspiredPerson.Values.ElementAt(1).ToString());
                }
            }
            catch
            {
                throw new Exception(k_InspiredPeopleFetchError);
            }
            
            return inspiredPeopleList;
        }

        public List<string> FetchArtistsList(string i_UserID = "me")
        {
            FacebookClient client = new FacebookClient(m_LoginResult.AccessToken);
            JsonObject me = client.Get(i_UserID + "?fields=music") as JsonObject;
            JsonObject artistsObject = me.Values.ElementAt(0) as JsonObject;
            JsonArray artists = artistsObject.Values.ElementAt(0) as JsonArray;
            List<string> ArtistList = new List<string>();

            try
            {
                foreach (JsonObject artist in artists)
                {
                    ArtistList.Add(artist.Values.ElementAt(0).ToString());
                }
            }
            catch
            {
                throw new Exception(k_ArtistsFetchError);
            }

            return ArtistList;
        }

        public string GetUserDateDaySummary(DateTime i_Date)
        {
            string daySummary;

            try
            {
                daySummary = DaySummariesDictionary[i_Date];
            }
            catch
            {
                daySummary = null;
            }

            return daySummary;
        }

        public void AddOrChangeDaySummaryDictionaryValue(DateTime i_Date, string i_DaySummary)
        {
            if (DaySummariesDictionary.ContainsKey(i_Date) == true)
            {
                DaySummariesDictionary[i_Date] = i_DaySummary;
            }
            else
            {
                DaySummariesDictionary.Add(i_Date, i_DaySummary);
            }
        }

        public List<string> FetchGroupsList(string i_UserID = "me")
        {
            FacebookClient client = new FacebookClient(m_LoginResult.AccessToken);
            JsonObject me = client.Get(i_UserID + "?fields=groups") as JsonObject;
            JsonObject groupsObject = me.Values.ElementAt(0) as JsonObject;
            JsonArray groups = groupsObject.Values.ElementAt(0) as JsonArray;
            List<string> groupsList = new List<string>();

            try
            {
                foreach (JsonObject group in groups)
                {
                    groupsList.Add(group.Values.ElementAt(0).ToString());
                }
            }
            catch
            {
                throw new Exception(k_GroupsFetchError);
            }

            return groupsList;
        }

        public void PostStatusOnWall(string i_StatusContent)
        {
             try
             {
                 m_LoggedInUser.PostStatus(i_StatusContent);
             }
             catch
             {
                 throw new Exception(k_FailedToPostError);
             }
        }

        public void LoggedOutFinished()
        {
            m_LoggedInUser = null;
        }
    }
}