using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookLogic
{
    public class UserToDosLogic
    {
        private const string k_ToDosListFetchError = "Failed to fetch to do list.";
        private readonly AppLogic r_AppLogic;

        public UserToDosLogic()
        {
            r_AppLogic = AppLogic.Instance;
        }

        public List<string> GetUserDateToDos(DateTime i_Date)
        {
            List<string> toDosList = new List<string>();

            try
            {
                foreach(KeyValuePair<DateTime, List<string>> toDo in r_AppLogic.UserToDoDictionary)
                {
                    if(toDo.Key.Date == i_Date.Date)
                    {
                        toDosList = toDo.Value;
                        break;
                    }
                }
            }
            catch
            {
                throw new Exception(k_ToDosListFetchError);
            }

            return toDosList;
        }

        public void AddToDoDictionaryValue(DateTime i_Date, string i_ToDoItemText)
        {
            if (r_AppLogic.UserToDoDictionary.ContainsKey(i_Date) == true)
            {
                r_AppLogic.UserToDoDictionary[i_Date].Add(i_ToDoItemText);
            }
            else
            {
                r_AppLogic.UserToDoDictionary.Add(i_Date, new List<string> { i_ToDoItemText });
            }
        }

        public void RemoveToDoDictionaryValue(DateTime i_Date, string i_ToDoItemText)
        {
            r_AppLogic.UserToDoDictionary[i_Date].Remove(i_ToDoItemText);
        }
    }
}