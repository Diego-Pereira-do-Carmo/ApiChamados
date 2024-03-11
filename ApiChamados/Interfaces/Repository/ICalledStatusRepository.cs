using ApiChamados.Models;

namespace ApiChamados.Interfaces
{
    public interface ICalledStatusRepository
    {
        void Add(CalledStatus calledStatus);

        Task<List<CalledStatus>> GetAll();
    }
}
