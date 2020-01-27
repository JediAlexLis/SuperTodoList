using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperTodoList.Models
{
    public class ListTodo
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<ListItem> ListItems { get; set; }
    }
}
