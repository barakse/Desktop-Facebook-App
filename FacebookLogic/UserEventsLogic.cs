using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    public class UserEventsLogic
    {
        private const string k_EventsFetchError = "Failed to fetch events.";
        private readonly AppLogic r_AppLogic;

        public UserEventsLogic()
        {
            r_AppLogic = AppLogic.Instance;
        }

        public FacebookObjectCollection<Event> GetUserDateEvents(DateTime i_SelectedDate)
        {
            try
            {
                FacebookObjectCollection<Event> todayEvents = new FacebookObjectCollection<Event>();

                foreach (Event facebookEvent in r_AppLogic.LoggedInUser.Events)
                {
                    if (facebookEvent.EndTime == null)
                    {
                        if (facebookEvent.StartTime.Value.Date == i_SelectedDate.Date)
                        {
                            todayEvents.Add(facebookEvent);
                        }
                    }
                    else if (facebookEvent.StartTime.Value.Date <= i_SelectedDate.Date
                             && facebookEvent.EndTime.Value.Date >= i_SelectedDate.Date)
                    {
                        todayEvents.Add(facebookEvent);
                    }
                }

                return todayEvents;
            }
            catch
            {
                throw new Exception(k_EventsFetchError);
            }
        }

        public string FormatHourFromDateTime(DateTime? i_DateTime)
        {
            TimeFormatAdapter timeFormat = new TimeFormatAdapter(i_DateTime);
            return timeFormat.FormatTimeFromDate();
        }
    }
}
