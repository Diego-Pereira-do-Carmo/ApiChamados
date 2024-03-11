using ApiChamados.Interfaces.Repository;
using ApiChamados.Interfaces.Service;
using ApiChamados.Models;

namespace ApiChamados.Service
{
    public class CalledService : ICalledService
    {
        private readonly ICalledRepository _calledRepository;

        public CalledService(ICalledRepository calledRepository)
        {
            _calledRepository = calledRepository;
        }

        public void Add(Called called)
        {
            _calledRepository.Add(called);
        }

        public async Task<List<Called>> GetAll()
        {
            return await _calledRepository.GetAll();
        }

        public string DeleteById(Guid id)
        {
            return _calledRepository.DeleteById(id);

        }
    }
}
