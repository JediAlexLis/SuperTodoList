﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperTodoList.Models
{
    public class Idea
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Position { get; set; }
        public int? ParentId { get; set; }
    }
}
