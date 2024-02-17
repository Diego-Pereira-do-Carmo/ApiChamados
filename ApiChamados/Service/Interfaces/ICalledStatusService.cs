using ApiChamados.Models;

namespace ApiChamados.Service.Interfaces
{
    public interface ICalledStatusService
    {
        public void Add(CalledStatus calledStatus);
        Task<List<CalledStatus>> FindAllAsync();
    }
}
