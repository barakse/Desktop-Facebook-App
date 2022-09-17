using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    public class MyDiaryFacade
    {
        private readonly UserEventsLogic r_UserEventsLogic;
        private readonly UserToDosLogic r_ToDosLogic;
        private readonly UserDaySummariesLogic r_UserDaySummariesLogic;

        public MyDiaryFacade()
        {
            r_UserEventsLogic = new UserEventsLogic();
            r_ToDosLogic = new UserToDosLogic();
            r_UserDaySummariesLogic = new UserDaySummariesLogic();
        }

        public FacebookObjectCollection<Event> GetUserDateEvents(DateTime i_SelectedDate)
        {
            return r_UserEventsLogic.GetUserDateEvents(i_SelectedDate);
        }

        public IEnumerator<string> GetUserDateToDos(DateTime i_Date)
        {
            r_ToDosLogic.ChosenDate = i_Date;
            return AppLogic.Instance.UserToDoDictionary.ContainsKey(i_Date) ? GetEnumerator() : null;
        }

        public void AddToDo(DateTime i_Date, string i_ToDoItemText)
        {
            r_ToDosLogic.AddToDoDictionaryValue(i_Date, i_ToDoItemText);
        }

        public void RemoveToDo(DateTime i_Date, string i_ToDoItemText)
        {
            r_ToDosLogic.RemoveToDoDictionaryValue(i_Date, i_ToDoItemText);
        }

        public string GetDaySummary(DateTime i_Date)
        {
            return r_UserDaySummariesLogic.GetUserDateDaySummary(i_Date);
        }

        public void AddOrChangeDaySummary(DateTime i_Date, string i_DaySummary)
        {
            r_UserDaySummariesLogic.AddOrChangeDaySummaryDictionaryValue(i_Date, i_DaySummary);
        }

        public string GetEventStartTime(Event i_Event)
        {
            return r_UserEventsLogic.FormatHourFromDateTime(i_Event.StartTime);
        }

        public string GetEventEndTime(Event i_Event)
        {
            return r_UserEventsLogic.FormatHourFromDateTime(i_Event.EndTime);
        }

        public IEnumerator<string> GetEnumerator()
        {
            return r_ToDosLogic.GetEnumerator();
        }
    }
}
