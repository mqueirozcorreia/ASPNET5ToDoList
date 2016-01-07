using ASPNET5ToDoList.Application;
using ASPNET5ToDoList.Models;
using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET5ToDoList.Controllers
{
    public class TodoItemController : Controller
    {
        private ITodoAppService TodoAppService;

        public TodoItemController(ITodoAppService pTodoAppService)
        {
            TodoAppService = pTodoAppService;
        }

        public IActionResult Index()
        {
            return View(TodoAppService.GetAll());
        }

        public IActionResult Add(TodoItem todoItem)
        {
            TodoAppService.Add(todoItem);
            return View("Index", TodoAppService.GetAll());
        }

        public IActionResult ChangeState(string title)
        {
            TodoAppService.ChangeState(title);
            return View("Index", TodoAppService.GetAll());
        }

        public IActionResult Remove(string title)
        {
            TodoAppService.Remove(title);
            return View("Index", TodoAppService.GetAll());
        }        
    }
}
