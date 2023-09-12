using TaskTracker.Modules.Tasks.Core.Enums;

namespace TaskTracker.Modules.Tasks.Core.Dto;
// public TaskLevel Level { get; set; }
// public string Tags { get; set; }
// public DateTime CreationDate { get; set; }
// public DateTime DueDate { get; set; }
// public Guid AssigneeId { get; set; }
public class TaskDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}

public class TaskDetailsDto : TaskDto
{
    public IssueDto Issue { get; set; }
}