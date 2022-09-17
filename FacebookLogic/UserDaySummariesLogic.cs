using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookLogic
{
    public class UserDaySummariesLogic
    {
        private readonly AppLogic r_AppLogic;

        public UserDaySummariesLogic()
        {
            r_AppLogic = AppLogic.Instance;
        }

        public string GetUserDateDaySummary(DateTime i_Date)
        {
            string daySummary;

            try
            {
                daySummary = r_AppLogic.DaySummariesDictionary[i_Date];
            }
            catch
            {
                daySummary = null;
            }

            return daySummary;
        }

        public void AddOrChangeDaySummaryDictionaryValue(DateTime i_Date, string i_DaySummary)
        {
            if (r_AppLogic.DaySummariesDictionary.ContainsKey(i_Date) == true)
            {
                r_AppLogic.DaySummariesDictionary[i_Date] = i_DaySummary;
            }
            else
            {
                r_AppLogic.DaySummariesDictionary.Add(i_Date, i_DaySummary);
            }
        }
    }
}