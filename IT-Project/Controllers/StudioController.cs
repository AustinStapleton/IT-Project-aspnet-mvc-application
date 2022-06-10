using IT_Project.Data;
using IT_Project.Data.Services;
using IT_Project.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace IT_Project.Controllers
{
    public class StudioController : Controller
    {
        private readonly IStudiosService _service;

        public StudioController(IStudiosService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allStudios = await _service.GetAllAsync();
            return View(allStudios);
        }
        //Get: Cinemas/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Logo,Name,Description")] Studio studio)
        {
            if (!ModelState.IsValid) return View(studio);
            await _service.AddAsync(studio);
            return RedirectToAction(nameof(Index));
        }

        //Get: Cinemas/Details/1
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var cinemaDetails = await _service.GetByIdAsync(id);
            if (cinemaDetails == null) return View("NotFound");
            return View(cinemaDetails);
        }

        //Get: Cinemas/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var cinemaDetails = await _service.GetByIdAsync(id);
            if (cinemaDetails == null) return View("NotFound");
            return View(cinemaDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Logo,Name,Description")] Studio studio)
        {
            if (!ModelState.IsValid) return View(studio);
            await _service.UpdateAsync(id, studio);
            return RedirectToAction(nameof(Index));
        }

        //Get: Cinemas/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var cinemaDetails = await _service.GetByIdAsync(id);
            if (cinemaDetails == null) return View("NotFound");
            return View(cinemaDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            var cinemaDetails = await _service.GetByIdAsync(id);
            if (cinemaDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
