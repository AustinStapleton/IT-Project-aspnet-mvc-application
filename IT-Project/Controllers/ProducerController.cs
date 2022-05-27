using IT_Project.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace IT_Project.Controllers
{
    public class ProducerController : Controller
    {
        private readonly AppDbContext _context;

        public ProducerController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var allProducers = _context.Producers.ToList();
            return View(allProducers);
        }
    }
}
