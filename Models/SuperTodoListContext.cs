using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperTodoList.Models
{
    public class SuperTodoListContext : DbContext
    {
        public DbSet<Idea> Ideas { get; set; }

        public SuperTodoListContext(DbContextOptions<SuperTodoListContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
