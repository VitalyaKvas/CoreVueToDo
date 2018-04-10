using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreVueToDo.Services;
using Microsoft.AspNetCore.Mvc;

namespace CoreVueToDo.Controllers
{
    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        private readonly ITodoItemService _todoItemService;

        public TodoController(ITodoItemService todoItemService)
        {
            _todoItemService = todoItemService;
        }

        // Handles GET /api/todo
        [HttpGet]
        public async Task<IActionResult> GetAllTodos()
        {
            var userId = "123"; // TODO: Get actual user ID
            var todos = await _todoItemService.GetItems(userId);

            return Ok(todos);
        }
    }
}