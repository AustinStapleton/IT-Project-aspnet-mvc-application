using IT_Project.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace IT_Project.Controllers
{
    public class StudioController : Controller
    {
        private readonly AppDbContext _context;

        public StudioController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allStudios = await _context.Studio.ToListAsync();
            return View(allStudios);
        }
    }
}
