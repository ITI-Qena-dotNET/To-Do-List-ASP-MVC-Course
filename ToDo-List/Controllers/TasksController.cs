using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDo_List.Data;
using ToDo_List.Models;

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
        var tasks = _context.Tasks.Include(x => x.User).ToList();
        return View(tasks);
    }

    public async Task<IActionResult> Details(int id)
    {
        var task = await _context.Tasks.Include(x => x.User).SingleOrDefaultAsync(x => x.ID == id);
        return View(task);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(TodoTask newTask)
    {
        if (!ModelState.IsValid)
            return View(newTask);

        newTask.AssignDate = DateTime.Now;
        await _context.Tasks.AddAsync(newTask);
        await _context.SaveChangesAsync();


        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Edit(int id)
    {
        var task = await _context.Tasks.Include(x => x.User).SingleOrDefaultAsync(x => x.ID == id);

        if (task is null)
            return NotFound();

        return View(task);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(TodoTask task)
    {
        if (!ModelState.IsValid)
            return View(task);

        _context.Tasks.Update(task);
        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Delete(int id)
    {
        await _context.Tasks.Where(x => x.ID == id).ExecuteDeleteAsync();
        return RedirectToAction(nameof(Index));
    }
}
