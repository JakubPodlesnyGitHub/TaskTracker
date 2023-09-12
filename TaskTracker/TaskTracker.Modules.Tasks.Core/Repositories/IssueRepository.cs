using Microsoft.EntityFrameworkCore;
using TaskTracker.Modules.Tasks.Core.EfCore.Dal;
using TaskTracker.Modules.Tasks.Core.Entities;
using TaskTracker.Modules.Tasks.Core.Repositories.Interfaces;

namespace TaskTracker.Modules.Tasks.Core.Repositories;

internal class IssueRepository : IIssueRepository
{
    private readonly TasksDbContext _context;

    public IssueRepository(TasksDbContext context)
    {
        _context = context;
    }

    public async Task InsertIssueAsync(Issue newIssue)
    {
        await _context.Issues.AddAsync(newIssue);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateIssueAsync(Issue updateIssue)
    {
        _context.Issues.Update(updateIssue);
        await _context.SaveChangesAsync();
    }

    public async Task<Guid> DeleteIssueAsync(Guid issueId)
    {
        var issueToDelete =  await _context.Issues.FindAsync(issueId);
        if (issueToDelete is null)
        {
            throw new NotImplementedException();
        }

        _context.Issues.Remove(issueToDelete);
        await _context.SaveChangesAsync();
        return issueToDelete.Id;
    }

    public async Task<IReadOnlyList<Issue>> GetIssuesAsync()
    {
        return await _context.Issues.ToListAsync();
    }

    public async Task<Issue> GetIssueByIdAsync(Guid issueId)
    {
        return await _context.Issues.SingleOrDefaultAsync(x => x.Id == issueId);
    }
}