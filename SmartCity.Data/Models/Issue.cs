using System;
using System.Collections.Generic;

namespace SmartCity.Data.Models
{
    public class Issue
        : BaseEntity
    {
        public string Title { get; set; }
        public IssueStatus Status { get; set; }

        public Guid IssueTypeId { get; set; }
        public virtual IssueType IssueType { get; set; }
        
        public Guid PollingPlaceId { get; set; }
        public virtual PollingPlace PollingPlace { get; set; }
        
        public Guid OrganizationId { get; set; }
        public virtual Organization Organisation { get; set; }
        
        public Guid AddressId { get; set; }
        public virtual Address Address { get; set; }

        public ICollection<DocumentIssue> DescribedFiles { get; set; }
        public ICollection<DocumentIssue> CompletedFiles { get; set; }
        public ICollection<IssueUser> IssueUsers { get; set; }
    }
}