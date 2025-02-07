using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitka.Domain.Models
{
    public class User
    {
        public User(Guid userId, string email, string password, UserRole role = UserRole.DefaultUser, DateTime? createdAt = null)
        {
            UserId = userId;
            Email = email;
            Password = password;
            Role = role;
            CreatedAt = createdAt ?? DateTime.UtcNow;
        }
        public Guid UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; } = UserRole.DefaultUser;
        public DateTime? CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
