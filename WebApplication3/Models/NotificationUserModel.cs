using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class NotificationUser
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Text { get; set; }
        public ApplicationUser User { get; set; }
        public bool IsRead { get; set; }
    }
}
