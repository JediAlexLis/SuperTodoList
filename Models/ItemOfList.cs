using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperTodoList.Models
{
    public class ItemOfList
    {
        public int ListId { get; set; }
        public int ActionId { get; set; }
        public int Position { get; set; }

        public ListTodo ListOfActions { get; set; }
        public Action Action { get; set; }
    }
}
