using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperTodoList.Models
{
    public class Action
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public List<ItemOfList> ListItems { get; set; }
    }
}
