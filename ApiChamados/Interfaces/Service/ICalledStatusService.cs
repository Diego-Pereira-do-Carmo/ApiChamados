using ApiChamados.Models;

namespace ApiChamados.Interfaces.Service
{
    public interface ICalledStatusService
    {
        public void Add(CalledStatus calledStatus);
        Task<List<CalledStatus>> GetAll();
    }
}
