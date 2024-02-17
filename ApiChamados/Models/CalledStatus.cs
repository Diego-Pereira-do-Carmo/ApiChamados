using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace ApiChamados.Models
{
    public class CalledStatus
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Name { get; set; }

        public CalledStatus() { }

        public CalledStatus(string name)
        {
            Name = name;
        }
    }
}
