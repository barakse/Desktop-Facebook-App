using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    public sealed class FiltersFacade
    {
        private readonly GenderFilterLogic r_GenderFilterLogic;
        private readonly BirthyearFilterLogic r_BirthyearFilterLogic;
        private readonly CityFilterLogic r_CityFilterLogic;
        private readonly MutualFiltersLogic r_MutualFiltersLogic;
        private readonly Dictionary<string, string> r_FilterResults = new Dictionary<string, string>();

        public string FilterParameterSelectedValue { get; set; }

        public Dictionary<string, string> FilterResults
        {
            get
            {
                return r_FilterResults;
            }
        }

        public FiltersFacade()
        {
           r_BirthyearFilterLogic = new BirthyearFilterLogic();
           r_GenderFilterLogic = new GenderFilterLogic();
           r_CityFilterLogic = new CityFilterLogic();
           r_MutualFiltersLogic = new MutualFiltersLogic();
        }

        public FacebookObjectCollection<User> FilterByGender()
        {
            return r_GenderFilterLogic.FilterByGender(FilterParameterSelectedValue);
        }

        public FacebookObjectCollection<User> FilterByBirthyear()
        {
            return r_BirthyearFilterLogic.FilterByBirthyear(FilterParameterSelectedValue);
        }

        public FacebookObjectCollection<User> FilterByCity()
        {
            return r_CityFilterLogic.FilterByCity(FilterParameterSelectedValue);
        }

        public FacebookObjectCollection<User> FilterByMutualGroups()
        {
            return r_MutualFiltersLogic.FilterByMutualGroups();
        }

        public FacebookObjectCollection<User> FilterByMutualArtists()
        {
            return r_MutualFiltersLogic.FilterByMutualArtists();
        }

        public FacebookObjectCollection<User> FilterByMutualLikedPages()
        {
            return r_MutualFiltersLogic.FilterByMutualLikedPages();
        }
    }
}