namespace ApiChamados.Domain.ViewModels
{
    public class CalledViewModel
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid CallStatusId { get; set; }
        public DateTime Deadline { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
