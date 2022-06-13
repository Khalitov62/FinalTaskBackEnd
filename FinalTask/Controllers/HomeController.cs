using FinalTask.DAL;
using FinalTask.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace FinalTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Home()
        {
            HomeVM homeVM = new HomeVM
            {
                Sliders = await _context.Sliders.ToListAsync()
            };
            return View(homeVM);
        }
    }

}
