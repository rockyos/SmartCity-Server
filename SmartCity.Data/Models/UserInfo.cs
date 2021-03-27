using System;

namespace SmartCity.Data.Models
{
    public class UserInfo
    {
        public Guid Id { get; set; }
        public virtual AppUser User { get; set; }
    }
}