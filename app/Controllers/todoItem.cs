﻿using app.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class todoItem : ControllerBase
    {
        List<TodoItem> todoItems=new List<TodoItem>();
        public todoItem()
        {
            todoItems.Add(new TodoItem
            {
                id = 1,
                Name="task1"
                ,isCompleted=true,

            });
            todoItems.Add(new TodoItem
            {
                id = 2,
                Name = "task2"
            ,
                isCompleted = true,

            });

            todoItems.Add(new TodoItem
            {
                id = 3,
                Name = "task3"
            ,
                isCompleted = false,

            });

            todoItems.Add(new TodoItem
            {
                id = 4,
                Name = "task4"
            ,
                isCompleted = false,

            });

        }
        [HttpGet]
        public List<TodoItem> Get()
        {
            return todoItems;
        }

    }
}