using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotGuava_NetCore_API.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
        public string Secret { get; set; }

        public TodoItem()
        {

        }
        public TodoItem(TodoItemDTO todoItemDTO)
        {
            Id = todoItemDTO.Id;
            Name = todoItemDTO.Name;
            IsComplete = todoItemDTO.IsComplete;
        }

    }
}
