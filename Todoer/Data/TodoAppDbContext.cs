using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Todoer.Models;

    public class TodoAppDbContext : DbContext
    {
        public TodoAppDbContext (DbContextOptions<TodoAppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Todoer.Models.Todo> Todo { get; set; } = default!;
    }
