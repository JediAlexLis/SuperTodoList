﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperTodoList.Models
{
    public class ListItem
    {
        public int ListId { get; set; }
        public int ActionId { get; set; }
        public int Position { get; set; }

        public ListOfActions ListOfActions { get; set; }
        public Action Action { get; set; }
    }
}
