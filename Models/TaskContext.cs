using Microsoft.EntityFrameworkCore;

namespace TaskManagerApi.Models
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base(options)
        {
        }

        public DbSet<Tasks> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Tasks>().HasData
            (
                new Tasks { Id = 1, Title = "do something", Description = "it's a test", DueDate = "12-23-2024", Status = TaskStatus.NotStarted },
                new Tasks { Id = 2, Title = "do something", Description = "it's a test", DueDate = "12-23-2024", Status = TaskStatus.InProgress },
                new Tasks { Id = 3, Title = "do something else", Description = "another test", DueDate = "01-15-2025", Status = TaskStatus.Completed },
                new Tasks { Id = 4, Title = "complete project", Description = "final test", DueDate = "02-10-2025", Status = TaskStatus.NotStarted },
                new Tasks { Id = 5, Title = "review code", Description = "code review task", DueDate = "03-05-2025", Status = TaskStatus.InProgress },
                new Tasks { Id = 6, Title = "write documentation", Description = "documentation task", DueDate = "03-20-2025", Status = TaskStatus.Completed },
                new Tasks { Id = 7, Title = "fix bugs", Description = "bug fixing task", DueDate = "04-01-2025", Status = TaskStatus.NotStarted },
                new Tasks { Id = 8, Title = "deploy application", Description = "deployment task", DueDate = "04-15-2025", Status = TaskStatus.InProgress }
            );
        }
    }
}

