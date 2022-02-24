#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TodoApp.Model;

namespace TodoApp.Data
{
    public class TodoAppContext : IdentityDbContext
    {
        public TodoAppContext (DbContextOptions<TodoAppContext> options)
            : base(options)
        {
        }
      
        public DbSet<TodoApp.Model.Tasks> Tasks { get; set; }

    }
}
