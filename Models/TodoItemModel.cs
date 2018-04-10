using System;

namespace CoreVueToDo.Models
{
    public class TodoItemModel
    {
        public Guid Id { get; set; }

        public string Text { get; set; }

        public bool Completed { get; set; }
    }
}