using ApiChamados.Models;

namespace ApiChamados.Interfaces.Repository
{
    public interface ICalledRepository
    {
        void Add(Called called);
        public Task<List<Called>> GetAll();
        public Task<Called> GetByCode(string code);
        public Task<List<Called>> GetByCalledStatusId(Guid calledStatusId);
        public Called GetById(Guid id);
        public string DeleteById(Guid id);
    }
}
