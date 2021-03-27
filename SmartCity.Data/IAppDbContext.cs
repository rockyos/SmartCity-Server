using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartCity.Data.Models;

namespace SmartCity.Data
{
    public interface IAppDbContext 
    {
        public DbSet<PollingPlace> PollingPlaces { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<UserInfo> UserInfos { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<UserDocument> UserDocuments { get; set; }
        public DbSet<Issue> Issues { get; set; }
        public DbSet<DocumentIssue> DocumentIssues { get; set; }
        public DbSet<IssueType> IssueTypes { get; set; }
        public DbSet<IssueUser> IssueUser { get; set; }
        public DbSet<Organization> Organization { get; set; }
        
        public DbSet<TEntity> Set<TEntity>() where TEntity : class;
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}