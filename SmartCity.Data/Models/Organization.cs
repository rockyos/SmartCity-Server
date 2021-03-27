using System.Collections.Generic;

namespace SmartCity.Data.Models
{
    public class Organization
        : BaseEntity
    {
        public virtual ICollection<Issue> Issues { get; set; }
    }
}