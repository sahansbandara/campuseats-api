
using Microsoft.AspNetCore.Mvc;

namespace CampusEats.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MenuController : ControllerBase
{
    [HttpGet]
    public IActionResult GetMenu()
    {
        var menu = new[]
        {
            new { Id = 1, Name = "Kottu Roti", Price = 750m, Category = "Mains", Available = true },
            new { Id = 2, Name = "Fried Rice", Price = 850m, Category = "Mains", Available = true },
            new { Id = 3, Name = "Veg Sub", Price = 600m, Category = "Snacks", Available = false },
            new { Id = 4, Name = "Watalappan", Price = 350m, Category = "Dessert", Available = true },
            new { Id = 5, Name = "Iced Milo", Price = 300m, Category = "Drinks", Available = true }
        };

        return Ok(menu);
    }
}
