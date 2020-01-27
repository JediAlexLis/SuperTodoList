using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperTodoList.Models
{
    public class SuperTodoListContext : DbContext
    {
        public DbSet<Action> Actions { get; set; }
        public DbSet<ListTodo> ListsTodo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemOfList>()
                .HasKey(k => new { k.ListId, k.ActionId, k.Position });

            modelBuilder.Entity<ItemOfList>()
                .HasOne(t => t.ListOfActions)
                .WithMany(t => t.Items)
                .HasForeignKey(k => k.ListId);

            modelBuilder.Entity<ItemOfList>()
                .HasOne(t => t.Action)
                .WithMany(t => t.ItemsOfLists)
                .HasForeignKey(k => k.ActionId);
        }
    }
}
