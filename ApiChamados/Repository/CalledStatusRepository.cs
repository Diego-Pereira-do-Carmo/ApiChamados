using ApiChamados.Context;
using ApiChamados.Interfaces;
using ApiChamados.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiChamados.Repository
{
    public class CalledStatusRepository : ICalledStatusRepository
    {
        private readonly ConnectionContext _context = new ConnectionContext();

        public void Add(CalledStatus calledStatus)
        {
            _context.CalledStatus.Add(calledStatus);
            _context.SaveChanges();
        }

        public async Task<List<CalledStatus>> GetAll()
        {
            return await _context.CalledStatus.OrderBy(s => s.Name).ToListAsync();
        }
    }
}
