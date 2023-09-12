namespace TaskTracker.Modules.Tasks.Core.Entities;

public class Issue
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime CreationDate {get; set; }
    public DateTime DueDate {get; set; }
    public IEnumerable<ProjectTask> ProjectTasks { get; set; }
    public IEnumerable<Guid> AssigneeIds { get; set; }
}