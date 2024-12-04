using Microsoft.EntityFrameworkCore;
using MyTurn_Backend.Models;

namespace MyTurn_Backend.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<TaskItem> Tasks { get; set; }
    }
}
