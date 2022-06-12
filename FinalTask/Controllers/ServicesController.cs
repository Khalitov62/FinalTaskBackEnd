using FinalTask.DAL;
using FinalTask.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace FinalTask.Controllers
{
    public class ServicesController : Controller
    {
        private readonly AppDbContext _context;

        public ServicesController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            ServicesVM servicesVM = new ServicesVM
            {
                Contacts = await _context.Contacts.ToListAsync(),
                Cards = await _context.Carts.ToListAsync(),
                Skills = await _context.Skills.FirstOrDefaultAsync(),
                Statisticas = await _context.Statics.ToListAsync()
            };
            return View(servicesVM);
        }
    }
}
