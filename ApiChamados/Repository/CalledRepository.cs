using ApiChamados.Context;
using ApiChamados.Interfaces;
using ApiChamados.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiChamados.Repository
{
    public class CalledRepository : ICalledRepository
    {
        private readonly ConnectionContext _context = new ConnectionContext();

        public void Add(Called called)
        {
            _context.Called.Add(called);
            _context.SaveChanges();
        }
    }
}
