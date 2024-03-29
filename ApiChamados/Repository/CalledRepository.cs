using ApiChamados.Context;
using ApiChamados.Interfaces.Repository;
using ApiChamados.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace ApiChamados.Repository
{
    public class CalledRepository : ICalledRepository
    {
        //private readonly ConnectionContext _context = new ConnectionContext();

        private readonly ConnectionContext _context;

        public CalledRepository(ConnectionContext context)
        {
            _context = context;
        }

        public void Add(Called called)
        {
            _context.Called.Add(called);
            _context.SaveChanges();
        }

        public async Task<List<Called>> GetAll()
        {
            return await _context.Called.OrderBy(c => c.CreatedOn).ToListAsync();
        }

        public async Task<Called> GetByCode(string code)
        {
            return await _context.Called.Where(c => c.Code == code).FirstOrDefaultAsync();
        }

        public Called GetById(Guid id)
        {
            return _context.Called.Find(id);
        }

        public async Task<List<Called>> GetByCalledStatusId(Guid calledStatusId)
        {
            return await _context.Called.Where(c => c.CalledStatusId == calledStatusId).OrderBy(c => c.CreatedOn).ToListAsync();
        }

        public string DeleteById(Guid id)
        {
            try
            {
                var called = GetById(id);

                if (called == null)
                {
                    return "Chamado não encontrado";
                }

                _context.Called.Remove(called);
                _context.SaveChanges();
                return "Chamado excluido com sucesso";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }

        }
    }
}
