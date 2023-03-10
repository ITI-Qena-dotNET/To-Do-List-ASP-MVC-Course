using Microsoft.AspNetCore.Mvc;
using ToDo_List.Data;

namespace ToDo_List.Controllers;

public class TasksController : Controller
{
    private readonly AppDbContext _context;

    public TasksController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var tasks = _context.Tasks.ToList();

        return View(tasks);
    }
}
