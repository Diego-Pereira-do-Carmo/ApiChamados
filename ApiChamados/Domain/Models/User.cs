using System.ComponentModel.DataAnnotations;

namespace ApiChamados.Domain.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public bool? isDeleted { get; set; }

        public User() { }

        public User(string userName, string email, string password, bool isAdmin)
        {
            Id = Guid.NewGuid();
            UserName = userName;
            Email = email;
            Password = password;
            IsAdmin = isAdmin;
            isDeleted = false;
        }
    }
}
