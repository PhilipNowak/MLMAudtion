using Microsoft.EntityFrameworkCore;
using MLM.Audtion.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MLM.Audition.Infrastructure.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<ToDoItem> ToDoItems { get; set; }
    }
}
