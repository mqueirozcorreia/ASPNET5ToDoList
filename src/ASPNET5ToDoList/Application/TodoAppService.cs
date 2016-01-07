using ASPNET5ToDoList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET5ToDoList.Application
{
    public class TodoAppService : ITodoAppService
    {
        public TodoAppService()
        {
            TodoItemList = new List<TodoItem>();
            Reset();
        }

        private List<TodoItem> TodoItemList { get; set; }

        public void Reset()
        {
            TodoItemList.Clear();
            TodoItemList.Add(new TodoItem()
            {
                Title = "Aprender MVC",
            });
        }

        public void Add(TodoItem todoItem)
        {
            TodoItemList.Add(todoItem);
        }

        public void Remove(string title)
        {
            TodoItemList.RemoveAll(t => t.Title == title);
        }

        public TodoItem ChangeState(string title)
        {
            TodoItem todoItem = TodoItemList
                .Where(t => t.Title == title)
                .FirstOrDefault();

            if (todoItem != null)
            {
                todoItem.Completed = !todoItem.Completed;
            }

            return todoItem;
        }

        public List<TodoItem> GetAll()
        {
            return TodoItemList;
        }
    }
}
