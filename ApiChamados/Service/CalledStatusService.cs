using ApiChamados.Context;
using ApiChamados.Interfaces;
using ApiChamados.Interfaces.Service;
using ApiChamados.Models;

namespace ApiChamados.Service
{
    public class CalledStatusService : ICalledStatusService
    {
        private readonly ICalledStatusRepository _calledStatusRepository;

        public CalledStatusService(ICalledStatusRepository calledStatusRepository)
        {
            _calledStatusRepository = calledStatusRepository;
        }

        public void Add(CalledStatus calledStatus)
        {
            _calledStatusRepository.Add(calledStatus);
        }

        public async Task<List<CalledStatus>> GetAll()
        {
            return await _calledStatusRepository.GetAll();
        }
    }
}
