using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskTracker.Modules.Tasks.Core.Entities;

namespace TaskTracker.Modules.Tasks.Core.Dal.DbConfigurations;

public class IssueDbConfiguration : IEntityTypeConfiguration<Issue>
{
    public void Configure(EntityTypeBuilder<Issue> builder)
    {
        
    }
}