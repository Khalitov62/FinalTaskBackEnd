using FinalTask.DAL;
using FinalTask.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinalTask.Services
{
    public class LayoutServices
    {
        private readonly AppDbContext _context;

        public LayoutServices(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Contact>> GetDatas()
        {
            List<Contact> contacts = await _context.Contacts.ToListAsync();

            return contacts;
        }
        public async Task<List<Statistica>> GetDataStatistic()
        {
            List<Statistica> statisticas = await _context.Statics.ToListAsync();

            return statisticas;
        }
    }

}
