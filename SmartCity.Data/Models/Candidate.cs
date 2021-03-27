using System;

namespace SmartCity.Data.Models
{
    public class Candidate
    : BaseEntity
    {
        public DateTime VotingYear { get; set; }
        public string VotingProgram { get; set; }
        public int BulletinNumber { get; set; }
        
        public Guid UserId { get; set; }
        public virtual AppUser User { get; set; }
        
        public Guid PollingPlaceId { get; set; }
        public virtual PollingPlace PollingPlace { get; set; }
    }
}