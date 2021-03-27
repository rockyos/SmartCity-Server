using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartCity.Data.Models;

namespace SmartCity.Data
{
    public class AppDbContext 
        : DbContext, IAppDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

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

        public DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            throw new System.NotImplementedException();
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<DocumentIssue>()
                .HasOne(di => di.Issue)
                .WithMany(i => i.CompletedFiles)
                .HasForeignKey(di => di.IssueId);

            modelBuilder.Entity<DocumentIssue>()
                .HasOne(di => di.Document)
                .WithMany(i => i.Issues)
                .HasForeignKey(di => di.DocumentId);

            modelBuilder.Entity<DocumentIssue>()
                .HasKey(di => new {di.DocumentId, di.IssueId});
            
            modelBuilder.Entity<IssueUser>()
                .HasKey(di => new {di.UserId, di.IssueId});
            
            modelBuilder.Entity<UserDocument>()
                .HasKey(di => new {di.UserId, di.PollingPlaceId});
        }
    }
}