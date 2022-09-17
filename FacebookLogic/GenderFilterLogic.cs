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
    public class GenderFilterLogic : ParameterFriendsFilterFetcher
    {
        protected override bool ShouldAdd(User i_Friend, object i_GenderType)
        {
            User.eGender selectedGender = i_GenderType as string == "Male" ? User.eGender.male : User.eGender.female;
            return i_Friend.Gender == selectedGender;
        }

        public FacebookObjectCollection<User> FilterByGender(string i_GenderType)
        {
            return FilterByParameter(i_GenderType);
        }
    }
}