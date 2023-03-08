using Microsoft.AspNetCore.Mvc;

namespace ToDo_List.Controllers;
public class TasksController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
