﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookLogic
{
    public class UserToDosLogic : IEnumerable<string>
    {
        private const string k_ToDosListFetchError = "Failed to fetch to do list.";
        private readonly AppLogic r_AppLogic;

        public DateTime ChosenDate { get; set; }

        public UserToDosLogic()
        {
            r_AppLogic = AppLogic.Instance;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            try
            {
                return GetEnumerator();
            }
            catch
            {
                throw new Exception(k_ToDosListFetchError);
            }
        }

        public IEnumerator<string> GetEnumerator()
        {
            foreach(string toDo in r_AppLogic.UserToDoDictionary[ChosenDate])
            {
                yield return toDo;
            }
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