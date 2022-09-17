using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    public class CityFilterLogic : ParameterFriendsFilterFetcher
    {
        protected override bool ShouldAdd(User i_Friend, object i_City)
        {
            string city = i_City as string;
            return i_Friend.Location.Name == city;
        }

        public FacebookObjectCollection<User> FilterByCity(string i_City)
        {
            return FilterByParameter(i_City);
        }
    }
}
