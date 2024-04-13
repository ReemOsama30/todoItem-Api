using app.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class todoItem : ControllerBase
    {
        List<TodoItem> todoItems = new List<TodoItem>();
        public todoItem()
        {
            todoItems.Add(new TodoItem
            {
                id = 1,
                Name = "task1",
                isCompleted = true,
            });

            todoItems.Add(new TodoItem
            {
                id = 2,
                Name = "task2",
                isCompleted = true,
            });

            todoItems.Add(new TodoItem
            {
                id = 3,
                Name = "task3",
                isCompleted = false,
            });

            todoItems.Add(new TodoItem
            {
                id = 4,
                Name = "task4",
                isCompleted = false,
            });
        }

        [HttpGet]
        public List<TodoItem> Get()
        {
            return todoItems;
        }

        [HttpGet("{id}")]
        public IActionResult getById(int id)
        {
            TodoItem item = todoItems.FirstOrDefault(t => t.id == id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpPost]
        public IActionResult post([FromBody] TodoItem item)
        {
            int newId = todoItems.Max(t => t.id) + 1;
            item.id = newId;

            todoItems.Add(item);

            return CreatedAtAction(nameof(getById), new { id = item.id }, item);
        }
    }
}
