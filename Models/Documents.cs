using System;
using System.Collections.Generic;

namespace dotnetDMS.Models
{
    public partial class Documents
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int OwnerId { get; set; }
        public int OwnerRoleId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Access { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Users Owner { get; set; }
    }
}
