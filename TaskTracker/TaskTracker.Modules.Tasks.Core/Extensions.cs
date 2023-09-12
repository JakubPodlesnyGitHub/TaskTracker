using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;

[assembly: InternalsVisibleTo("TaskTracker.Modules.Tasks.Api")]
namespace TaskTracker.Modules.Tasks.Core;
internal static class Extensions
{
    public static IServiceCollection AddCore(this IServiceCollection services)
    {
        services.AddCore();
        return services;
    }
}