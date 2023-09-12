using Microsoft.EntityFrameworkCore;
using TaskTracker.Modules.Tasks.Core.Entities;

namespace TaskTracker.Modules.Tasks.Core.EfCore.Dal;

internal class TasksDbContext : DbContext
{
    public DbSet<ProjectTask> ProjectTasks { get; set; }
    public DbSet<Issue> Issues { get; set; }

    public TasksDbContext(DbContextOptions<TasksDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("Tasks");
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }
}