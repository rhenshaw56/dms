using System;
using System.Collections.Generic;

namespace dotnetDMS.Models
{
    public partial class Users
    {
        public Users()
        {
            Documents = new HashSet<Documents>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public string CurrentToken { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Roles Role { get; set; }
        public ICollection<Documents> Documents { get; set; }
    }
}
