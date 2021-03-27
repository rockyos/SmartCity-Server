using System.Collections.Generic;

namespace SmartCity.Data.Models
{
    public class IssueType
        : BaseEntity
    {
        public string Name { get; set; }
        
        public ICollection<Issue> Issues { get; set; }
    }
}