using TaskTracker.Modules.Tasks.Core.Entities;

namespace TaskTracker.Modules.Tasks.Core.Repositories.Interfaces;

internal interface IIssueRepository
{
    Task InsertIssueAsync(Issue newIssue);
    Task UpdateIssueAsync(Issue updateIssue);
    Task<Guid> DeleteIssueAsync(Guid issueId);
    Task<IReadOnlyList<Issue>> GetIssuesAsync();
    Task<Issue> GetIssueByIdAsync(Guid issueId);
}