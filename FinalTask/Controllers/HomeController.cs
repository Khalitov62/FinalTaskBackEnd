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
        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new HomeVM
            {
                Sliders = await _context.Sliders.ToListAsync(),
                AboutCards = await _context.AboutCards.ToListAsync(),
                AboutImgs = await _context.AboutImgs.FirstOrDefaultAsync(),
                HomeCards = await _context.HomeCards.ToListAsync(),
                HomeBrands = await _context.HomeBrands.ToListAsync()
            };
            return View(homeVM);
        }
    }

}
