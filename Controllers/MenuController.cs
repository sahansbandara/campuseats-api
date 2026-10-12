
using CampusEats.Api.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CampusEats.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MenuController : ControllerBase
{
    private readonly CampusEatsDbContext _db;

    public MenuController(CampusEatsDbContext db)
    {
        _db = db;
    }

    [HttpGet]
    public async Task<IActionResult> GetMenu()
    {
        var menu = await _db.MenuItems
            .AsNoTracking()
            .OrderBy(item => item.Id)
            .ToListAsync();

        return Ok(menu);
    }
}
