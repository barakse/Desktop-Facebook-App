using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookLogic
{
    public class MutualLikedPagesStrategy : IMutualFilterStrategy
    {
        public List<string> FetchUserCollectionToScan(string i_UserId)
        {
            return AppLogic.Instance.FetchLikedPagesList(i_UserId);
        }
    }
}
