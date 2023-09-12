using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("TaskTracker.Bootstrapper")]
namespace TaskTracker.Modules.Tasks.Api;
internal static class Extensions
{
    public static IServiceCollection AddTasks(this IServiceCollection services)
    {
        services.AddControllers();
        return services;
    }
}