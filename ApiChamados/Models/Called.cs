using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ApiChamados.Models
{
    public class Called
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public CalledStatus CalledStatus { get; set; }
        public Guid CalledStatusId { get; set; }
        public DateTime Deadline { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public Guid? ModifiedBy { get; set; }

        public Called() { }

        public Called(string code, string title, string description, Guid status)
        {
            Code = code;
            Title = title;
            Description = description;
            CalledStatusId = status;
            Deadline = DateTime.Now.AddDays(5);
            CreatedBy = Guid.Empty;
            CreatedOn = DateTime.Now;
            ModifiedOn = null;
            ModifiedBy = null;
        }
    }
}
