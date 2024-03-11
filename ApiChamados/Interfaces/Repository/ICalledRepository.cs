using ApiChamados.Models;

namespace ApiChamados.Interfaces.Repository
{
    public interface ICalledRepository
    {
        void Add(Called called);
        public Task<List<Called>> GetAll();
        public Called GetById(Guid id);
        public string DeleteById(Guid id);
    }
}
