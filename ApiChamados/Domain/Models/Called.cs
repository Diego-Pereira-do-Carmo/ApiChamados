namespace ApiChamados.Domain.Models
{
    public class Called
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid CallStatusId { get; set; }
        public DateTime Deadline { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public Guid? ModifiedBy { get; set; }
        public bool? isDeleted { get; set; }

        public Called() { }

        public Called(string code, string title, string description, Guid callStatusId, DateTime deadline)
        {
            Id = Guid.NewGuid();
            Code = code;
            Title = title;
            Description = description;
            CallStatusId = callStatusId;
            CreatedOn = DateTime.Now;
            Deadline = CreatedOn.AddDays(5);
            //CreatedBy = CurrentUser.Id;
            ModifiedOn = null;
            ModifiedBy = null;
            isDeleted = false;
        }
    }
}
