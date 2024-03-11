using ApiChamados.Models;

namespace ApiChamados.Interfaces.Service
{
    public interface ICalledService
    {
        public void Add(Called called);
        public Task<List<Called>> GetAll();
        public string DeleteById(Guid id);
    }
}
