using ApiChamados.Models;

namespace ApiChamados.ViewModels
{
    public class CalledViewModel
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid StatusId { get; set; }
    }
}
