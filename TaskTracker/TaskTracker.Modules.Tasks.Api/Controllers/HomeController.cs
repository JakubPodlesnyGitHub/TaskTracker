using Microsoft.AspNetCore.Mvc;

namespace TaskTracker.Modules.Tasks.Api;

[Route("task-module")]
public class HomeController : ControllerBase
{
    [HttpGet]
    public ActionResult<string> Get() => "Task API";
}