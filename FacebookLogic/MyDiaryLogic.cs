using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    public class MyDiaryLogic
    {
        private DateTime m_ChosenDateTime;
        private List<string> m_ChosenDayToDoList;
        private string m_ChosenDaySummary;
        private string m_ToDoNewItem;

        public MyDiaryLogic()
        {
            ChosenDayToDoList = new List<string>();
            ChosenDaySummary = null;
            ToDoNewItem = null;
            ChosenDateTime = new DateTime();
        }

        public DateTime ChosenDateTime
        {
            get
            {
                return m_ChosenDateTime;
            }

            set
            {
                m_ChosenDateTime = value;
            }
        }

        public List<string> ChosenDayToDoList
        {
            get
            {
                return m_ChosenDayToDoList;
            }

            set
            {
                m_ChosenDayToDoList = value;
            }
        }

        public string ChosenDaySummary
        {
            get
            {
                return m_ChosenDaySummary;
            }

            set
            {
                m_ChosenDaySummary = value;
            }
        }

        public string ToDoNewItem
        {
            get
            {
                return m_ToDoNewItem;
            }

            set
            {
                m_ToDoNewItem = value;
            }
        }

        public string FormatHourFromDateTime(DateTime? i_DateTime)
        {
            string hour = string.Format(
                "{0}{1}:{2}{3}",
                i_DateTime.Value.Hour <= 9 ? "0" : string.Empty,
                i_DateTime.Value.Hour,
                i_DateTime.Value.Minute <= 9 ? "0" : string.Empty,
                i_DateTime.Value.Minute);

            return hour;
        }
    }
}