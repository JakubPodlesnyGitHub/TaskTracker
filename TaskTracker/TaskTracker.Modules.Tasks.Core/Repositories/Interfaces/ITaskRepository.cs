using TaskTracker.Modules.Tasks.Core.Entities;

namespace TaskTracker.Modules.Tasks.Core.Repositories.Interfaces;

internal interface ITaskRepository
{
    Task InsertTaskAsync(ProjectTask newTask);
    Task UpdateTaskAsync(ProjectTask updateTask);
    Task<Guid> DeleteTaskAsync(Guid taskId);
    Task<IReadOnlyList<ProjectTask>> GetTasksAsync();
    Task<ProjectTask> GetTaskByIdAsync(Guid taskId);
}