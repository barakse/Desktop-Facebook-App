using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
        private const string k_NoTicketsEventMessage = @"This event might not have a site to purchase a ticket.
Please try to check for more information it's page.";

        private readonly MainAppFacade r_MainAppFacade;
        private readonly MyDiaryFacade r_MyDiaryFacade;
        private IEnumerator<string> m_ToDosEnumerator;

        public MyDiaryForm()
        {
            r_MainAppFacade = MainAppFacade.Instance;
            r_MyDiaryFacade = new MyDiaryFacade();
            InitializeComponent();
            ToDoListDeleteItemButton.Visible = false;
            NoDaySummaryLabel.Visible = true;
            NoToDosLabel.Visible = true;
            daySummariesDictionaryBindingSource.DataSource = r_MainAppFacade.DaySummariesDictionary;
            ProfilePictureBox.ImageLocation = r_MainAppFacade.FetchSmallProfilePictureUrl();
            new Thread(() => loadDateData(MonthCalendar.SelectionRange.Start.Date)).Start();
        }

        private void loadDateData(DateTime i_Date)
        {
            loadDateEvents(i_Date);
            loadDateToDoList(i_Date);
            loadDateDaySummary(i_Date);
        }

        private void loadDateEvents(DateTime i_Date)
        {
            eventBindingSource.DataSource = r_MyDiaryFacade.GetUserDateEvents(i_Date);
            FacebookObjectCollection<Event> dataSource = eventBindingSource.DataSource as FacebookObjectCollection<Event>;
            EventsDataGrid.DataSource = dataSource;
            NoEventsLabel.Visible = dataSource.Count <= 0;
        }

        private void loadDateToDoList(DateTime i_Date)
        {
            TodayToDoList.Items.Clear();
            NoToDosLabel.Visible = true;

            m_ToDosEnumerator = r_MyDiaryFacade.GetUserDateToDos(i_Date);

                using(IEnumerator<string> iterator = m_ToDosEnumerator)
                {
                    if(iterator != null)
                    {
                        while(iterator.MoveNext())
                        {
                            if(!string.IsNullOrEmpty(iterator.Current))
                            {
                                TodayToDoList.Items.Add(iterator.Current);
                            }
                        }

                        if(TodayToDoList.Items.Count > 0)
                        {
                            NoToDosLabel.Visible = false;
                        }
                    }
                }
        }

        private void loadDateDaySummary(DateTime i_Date)
        {
            Dictionary<DateTime, string> dataSource =
                daySummariesDictionaryBindingSource.DataSource as Dictionary<DateTime, string>;

            if(dataSource.Count != 0)
            {
                DaySummaryAreaLabel.Text = dataSource.ContainsKey(i_Date) ? dataSource[i_Date] : string.Empty;
            }

            NoDaySummaryLabel.Visible = string.IsNullOrEmpty(DaySummaryAreaLabel.Text) ? true : false;
        }

        private void MonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            ToDoListDeleteItemButton.Visible = false;
            new Thread(() => loadDateData(e.Start)).Start();
        }

        private void EventsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                string url = (EventsDataGrid.Rows[e.RowIndex].Cells[1] as DataGridViewLinkCell).Value.ToString();
                System.Diagnostics.Process.Start(url);
            }
        }

        private void EventsDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 1)
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
            DateTime chosenDateTime = MonthCalendar.SelectionRange.Start.Date;
            ToDoInputForm toDoInputForm = new ToDoInputForm(r_MyDiaryFacade);
            toDoInputForm.ShowDialog();

            if(!string.IsNullOrEmpty(toDoInputForm.ToDoNewItem))
            {
                TodayToDoList.Items.Add(toDoInputForm.ToDoNewItem);
                r_MyDiaryFacade.AddToDo(chosenDateTime, toDoInputForm.ToDoNewItem);
                NoToDosLabel.Visible = false;
            }
        }

        private void ToDoListDeleteItemButton_Click(object sender, EventArgs e)
        {
            DateTime chosenDateTime = MonthCalendar.SelectionRange.Start.Date;
            int selectedIndex = TodayToDoList.SelectedIndex;

            if(selectedIndex >= 0)
            {
                r_MyDiaryFacade.RemoveToDo(
                    chosenDateTime,
                    TodayToDoList.Items[selectedIndex].ToString());
                TodayToDoList.Items.RemoveAt(selectedIndex);
                ToDoListDeleteItemButton.Visible = false;
                NoToDosLabel.Visible = TodayToDoList.Items.Count == 0 ? true : false;
            }
        }

        private void EditDaySummaryButton_Click(object sender, EventArgs e)
        {
            DateTime chosenDateTime = MonthCalendar.SelectionRange.Start.Date;
            DaySummaryEditForm daySummaryEditForm = new DaySummaryEditForm(r_MyDiaryFacade, chosenDateTime);
            daySummaryEditForm.ShowDialog();

            if(daySummaryEditForm.ChosenDaySummary != DaySummaryAreaLabel.Text)
            {
                DaySummaryAreaLabel.Text = daySummaryEditForm.ChosenDaySummary;
                r_MainAppFacade.AddOrChangeDaySummary(chosenDateTime, DaySummaryAreaLabel.Text);
                NoDaySummaryLabel.Visible = string.IsNullOrEmpty(DaySummaryAreaLabel.Text) ? true : false;
            }
        }

        private void EventsDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            eventBindingSource.Position = EventsDataGrid.CurrentRow.Index;
            Event currentEventSelected = eventBindingSource.Current as Event;

            if (currentEventSelected != null)
            {
                EventOwnerLabel.Text = currentEventSelected.Owner != null ? currentEventSelected.Owner.Name : "-";
                EventLocationLabel.Text = currentEventSelected.Place.Name;
                EventCoverPicture.ImageLocation = currentEventSelected.Cover.SourceURL;
                EventStartTimeLabel.Text = r_MyDiaryFacade.GetEventStartTime(currentEventSelected);
                EventEndTimeLabel.Text = r_MyDiaryFacade.GetEventEndTime(currentEventSelected);
                EventTicketsLinkLabel.Visible = true;
            }
            else
            {
                EventOwnerLabel.Text = "-";
                EventLocationLabel.Text = "-";
                EventCoverPicture.ImageLocation = "-";
                EventStartTimeLabel.Text = "-";
                EventEndTimeLabel.Text = "-";
                EventTicketsLinkLabel.Visible = false;
            }
        }

        private void EventTicketsLinkLabel_Click(object sender, EventArgs e)
        {
            string eventTicketsUrl = (eventBindingSource.Current as Event).TicketsURI;

            if(!string.IsNullOrEmpty(eventTicketsUrl))
            {
                System.Diagnostics.Process.Start(eventTicketsUrl);
            }
            else
            {
                MessageBox.Show(
                    k_NoTicketsEventMessage,
                    "Purchasing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}