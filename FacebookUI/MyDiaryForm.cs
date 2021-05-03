using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookLogic;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookUI
{
    public partial class MyDiaryForm : Form
    {
        private readonly AppLogic r_AppLogic;
        private readonly MyDiaryLogic r_DiaryLogic;

        public MyDiaryForm(AppLogic i_AppLogic)
        {
            r_AppLogic = i_AppLogic;
            r_DiaryLogic = new MyDiaryLogic();
            InitializeComponent();
            ToDoListDeleteItemButton.Visible = false;
            r_DiaryLogic.ChosenDateTime = MonthCalendar.SelectionRange.Start.Date;
            loadDateData(r_DiaryLogic.ChosenDateTime);
            MainApp.LoadProfilePicture(ProfilePictureBox, r_AppLogic);
        }

        private void loadDateData(DateTime i_Date)
        {
            loadDateEvents(i_Date);
            loadDateToDoList(i_Date);
            loadDateDaySummary(i_Date);
        }

        private void loadDateEvents(DateTime i_Date)
        {
            EventsDataGrid.Rows.Clear();

            List<Event> dateEvents = r_AppLogic.GetUserDateEvents(i_Date);

            if (dateEvents.Count > 0)
            {
                NoEventsLabel.Visible = false;

                foreach (Event facebookEvent in dateEvents)
                {
                    string startTime = r_DiaryLogic.FormatHourFromDateTime(facebookEvent.StartTime);
                    string endTime = facebookEvent.EndTime != null
                                         ? r_DiaryLogic.FormatHourFromDateTime(facebookEvent.EndTime)
                                         : "-";

                    EventsDataGrid.Rows.Add(facebookEvent.Name, startTime, endTime, facebookEvent.LinkToFacebook);
                }
            }
            else
            {
                NoEventsLabel.Visible = true;
            }
        }

        private void loadDateToDoList(DateTime i_Date)
        {
            TodayToDoList.Items.Clear();

            r_DiaryLogic.ChosenDayToDoList = r_AppLogic.GetUserDateToDos(i_Date);

            if (r_DiaryLogic.ChosenDayToDoList.Count > 0)
            {
                NoToDosLabel.Visible = false;

                foreach (string toDo in r_DiaryLogic.ChosenDayToDoList)
                {
                    TodayToDoList.Items.Add(toDo);
                }
            }
            else
            {
                NoToDosLabel.Visible = true;
            }
        }

        private void loadDateDaySummary(DateTime i_Date)
        {
            r_DiaryLogic.ChosenDaySummary = r_AppLogic.GetUserDateDaySummary(i_Date);
            DaySummaryAreaLabel.Text = r_DiaryLogic.ChosenDaySummary;
            NoDaySummaryLabel.Visible = string.IsNullOrEmpty(DaySummaryAreaLabel.Text) ? true : false;
        }

        private void MonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            ToDoListDeleteItemButton.Visible = false;
            r_DiaryLogic.ChosenDateTime = e.Start;
            loadDateData(r_DiaryLogic.ChosenDateTime);
        }

        private void EventsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                string url = (EventsDataGrid.Rows[e.RowIndex].Cells[3] as DataGridViewLinkCell).Value.ToString();
                System.Diagnostics.Process.Start(url);
            }
        }

        private void EventsDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 3)
            {
                e.Value = "View";
            }
        }

        private void TodayToDoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = TodayToDoList.SelectedIndex;

            if(selectedIndex >= 0 && TodayToDoList.Items.Count != 0)
            {
                ToDoListDeleteItemButton.Visible = true;
            }
        }

        private void ToDoListAddItemButton_Click(object sender, EventArgs e)
        {
            r_DiaryLogic.ToDoNewItem = null;
            new ToDoInputForm(r_DiaryLogic).ShowDialog();

            if(!string.IsNullOrEmpty(r_DiaryLogic.ToDoNewItem))
            {
                TodayToDoList.Items.Add(r_DiaryLogic.ToDoNewItem);
                r_AppLogic.AddToDoDictionaryValue(r_DiaryLogic.ChosenDateTime, r_DiaryLogic.ToDoNewItem);
                NoToDosLabel.Visible = false;
            }
        }

        private void ToDoListDeleteItemButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = TodayToDoList.SelectedIndex;

            if(selectedIndex >= 0)
            {
                r_AppLogic.RemoveToDoDictionaryValue(
                    r_DiaryLogic.ChosenDateTime,
                    TodayToDoList.Items[selectedIndex].ToString());
                TodayToDoList.Items.RemoveAt(selectedIndex);
                ToDoListDeleteItemButton.Visible = false;
                NoToDosLabel.Visible = TodayToDoList.Items.Count == 0 ? true : false;
            }
        }

        private void EditDaySummaryButton_Click(object sender, EventArgs e)
        {
            new DaySummaryEditForm(r_DiaryLogic).ShowDialog();

            if(r_DiaryLogic.ChosenDaySummary != DaySummaryAreaLabel.Text)
            {
                DaySummaryAreaLabel.Text = r_DiaryLogic.ChosenDaySummary;
                r_AppLogic.AddOrChangeDaySummaryDictionaryValue(r_DiaryLogic.ChosenDateTime, r_DiaryLogic.ChosenDaySummary);
                NoDaySummaryLabel.Visible = string.IsNullOrEmpty(DaySummaryAreaLabel.Text) ? true : false;
            }
        }
    }
}
