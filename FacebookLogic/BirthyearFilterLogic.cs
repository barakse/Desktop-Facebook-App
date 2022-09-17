using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    public class BirthyearFilterLogic : ParameterFriendsFilterFetcher
    {
        protected override bool ShouldAdd(User i_Friend, object i_BirthYear)
        {
            string birthyear = i_BirthYear as string;
            return i_Friend.Birthday.Substring(6) == birthyear;
        }

        public FacebookObjectCollection<User> FilterByBirthyear(string i_BirthYear)
        {
            return FilterByParameter(i_BirthYear);
        }
    }
}
