using System.Collections.Generic;

namespace SmartCity.Data.Models
{
    public class Document
        : BaseEntity 
    {
        public ICollection<DocumentIssue> Issues { get; set; }
    }
}