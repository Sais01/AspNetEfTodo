using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeuTodo.Models;
using Microsoft.EntityFrameworkCore;

namespace MeuTodo.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<Todo> Todos { get; set; } //Um DbSet da classe no Model Todo chamado Todos

        // Setando ConnectStrings
        // O ideal é usar o appsettings
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite(connectionString: "DataSource=app.db;Cache=Shared");
    }
}