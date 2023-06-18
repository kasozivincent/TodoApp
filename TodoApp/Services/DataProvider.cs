using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Model;

namespace TodoApp.Services
{
    public class DataProvider
    {
        public List<TodoItem> Read()
        {
            return new List<TodoItem>()
            {
              new TodoItem
              {
                Title = "Go for my exam",
                Description = "I have to go and buy some legumes",
                Priority = Priority.Normal,
                IsDone = true
              },
              new TodoItem
              {
                Title = "Go to the market",
                Description = "I have to go and buy some legumes",
                Priority = Priority.Normal,
                IsDone = false
              },
              new TodoItem
              {
                Title = "Go to the market",
                Description = "I have to go and buy some legumes",
                Priority = Priority.Normal,
                IsDone = true
              },
              new TodoItem
              {
                Title = "Take my dog for a walk",
                Description = "I have to go and buy some legumes",
                Priority = Priority.Normal,
                IsDone = false
              }
            };
        }
    }
}

