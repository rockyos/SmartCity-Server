using System;

namespace SmartCity.Data.Models
{
    public class IssueUser
    {
        public Guid UserId { get; set; }
        public virtual AppUser AppUser { get; set; }
        
        public Guid IssueId { get; set; }
        public virtual Issue Issue { get; set; }
    }
}