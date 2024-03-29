using ApiChamados.Models;

namespace ApiChamados.Interfaces.Service
{
    public interface ICalledService
    {
        public void Add(Called called);
        public Task<List<Called>> GetAll();
        public Task<Called> GetByCode(string code);
        public Task<List<Called>> GetByCalledStatusId(Guid calledStatusId);
        public string DeleteById(Guid id);
    }
}
