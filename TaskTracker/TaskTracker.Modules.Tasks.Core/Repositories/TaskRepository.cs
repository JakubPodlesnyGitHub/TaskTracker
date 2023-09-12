using Microsoft.EntityFrameworkCore;
using TaskTracker.Modules.Tasks.Core.EfCore.Dal;
using TaskTracker.Modules.Tasks.Core.Entities;
using TaskTracker.Modules.Tasks.Core.Repositories.Interfaces;

namespace TaskTracker.Modules.Tasks.Core.Repositories;

internal class TaskRepository : ITaskRepository
{
    private readonly TasksDbContext _context;

    public TaskRepository(TasksDbContext context)
    {
        _context = context;
    }

    public async Task InsertTaskAsync(ProjectTask newTask)
    {
        await _context.AddAsync(newTask);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateTaskAsync(ProjectTask updateTask)
    {
        _context.ProjectTasks.Update(updateTask);
        await _context.SaveChangesAsync();
    }

    public async Task<Guid> DeleteTaskAsync(Guid taskId)
    {
        var taskToRemove = await _context.ProjectTasks.FindAsync(taskId);
        if (taskToRemove is null)
        {
            throw new NotImplementedException();
        }

        _context.ProjectTasks.Remove(taskToRemove);
        await _context.SaveChangesAsync();
        return taskToRemove.Id;
    }

    public async Task<IReadOnlyList<ProjectTask>> GetTasksAsync()
    {
        return await _context.ProjectTasks.ToListAsync();
    }

    public async Task<ProjectTask> GetTaskByIdAsync(Guid taskId)
    {
        return await _context.ProjectTasks.SingleOrDefaultAsync(x => x.Id == taskId);
    }
}