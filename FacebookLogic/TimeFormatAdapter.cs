using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookLogic
{
    public class TimeFormatAdapter : ITimeFormat
    {
        private readonly DateTime? r_DateTime;

        public TimeFormatAdapter(DateTime? i_DateTime)
        {
            r_DateTime = i_DateTime;
        }

        public string FormatTimeFromDate()
        {
            string hour = "-";

            if (r_DateTime != null)
            {
                hour = string.Format(
                    "{0}{1}:{2}{3}",
                    r_DateTime.Value.Hour <= 9 ? "0" : string.Empty,
                    r_DateTime.Value.Hour,
                    r_DateTime.Value.Minute <= 9 ? "0" : string.Empty,
                    r_DateTime.Value.Minute);
            }

            return hour;
        }
    }
}
