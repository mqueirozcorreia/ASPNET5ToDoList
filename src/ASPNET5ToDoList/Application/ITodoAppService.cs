using ASPNET5ToDoList.Models;
using System.Collections.Generic;

namespace ASPNET5ToDoList.Application
{
    public interface ITodoAppService
    {
        void Add(TodoItem todoItem);
        TodoItem ChangeState(string title);
        void Remove(string title);
        void Reset();
        List<TodoItem> GetAll();
    }
}