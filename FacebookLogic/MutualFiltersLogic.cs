using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    public class MutualFiltersLogic
    {
        private const string k_EmptyGroupsListError = "You have an empty groups list.";
        private const string k_EmptyArtistsListError = "You have an empty artists list.";
        private const string k_EmptyLikedPagesListError = "You have an empty liked pages list.";

        public FacebookObjectCollection<User> FilterByMutualGroups()
        {
            MutualFilterFetcher mutualGroupsFilterFetcher = new MutualFilterFetcher(
                new MutualGroupsStrategy(),
                k_EmptyGroupsListError);
            return mutualGroupsFilterFetcher.FilterByMutual();
        }

        public FacebookObjectCollection<User> FilterByMutualLikedPages()
        {
            MutualFilterFetcher mutualLikedPagesFilterFetcher = new MutualFilterFetcher(
                new MutualLikedPagesStrategy(),
                k_EmptyLikedPagesListError);
            return mutualLikedPagesFilterFetcher.FilterByMutual();
        }

        public FacebookObjectCollection<User> FilterByMutualArtists()
        {
            MutualFilterFetcher mutualArtistsFilterFetcher = new MutualFilterFetcher(
                new MutualArtistsStrategy(),
                k_EmptyArtistsListError);
            return mutualArtistsFilterFetcher.FilterByMutual();
        }
    }
}