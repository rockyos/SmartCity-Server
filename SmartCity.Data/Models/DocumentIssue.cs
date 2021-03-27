using System;

namespace SmartCity.Data.Models
{
    public class DocumentIssue
    {
        public Guid IssueId { get; set; }
        public virtual Issue Issue { get; set; }
        
        public Guid DocumentId { get; set; }
        public virtual Document Document { get; set; }
    }
}