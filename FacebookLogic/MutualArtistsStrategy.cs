using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookLogic
{
    public class MutualArtistsStrategy : IMutualFilterStrategy
    {
        public List<string> FetchUserCollectionToScan(string i_UserId)
        {
            return AppLogic.Instance.FetchArtistsList(i_UserId);
        }
    }
}
