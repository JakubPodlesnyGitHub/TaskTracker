using TaskTracker.Modules.Tasks.Api;
using TaskTracker.Shared.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddInfrastructure();
builder.Services.AddTasks();
var app = builder.Build();

app.MapControllers();
app.MapGet("/", () => "TaskTracker API!");
app.Run();