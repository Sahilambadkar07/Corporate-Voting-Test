using Corporate_Voting_Test.Models;
using Microsoft.EntityFrameworkCore;


namespace Corporate_Voting_Test.Data
{ 
        public class VotingSystemDbContext : DbContext
        {
        public VotingSystemDbContext() : base()
        {
            Console.WriteLine("Connection Established");
        }
        public VotingSystemDbContext(DbContextOptions<VotingSystemDbContext> options)
                : base(options)
            {
            }

            public DbSet<User> Users { get; set; }
            public DbSet<Election> Elections { get; set; }
            public DbSet<Candidate> Candidates { get; set; }
            public DbSet<Vote> Votes { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Candidate>()
                    .HasOne(e => e.Election)
                    .WithMany(c => c.Candidates)
                    .HasForeignKey(e => e.ElectionId)
                    .OnDelete(DeleteBehavior.Cascade);

                modelBuilder.Entity<Vote>()
                    .HasOne(u => u.User)
                    .WithMany()
                    .HasForeignKey(u => u.UserId)
                    .OnDelete(DeleteBehavior.Cascade);

                modelBuilder.Entity<Vote>()
                    .HasOne(c => c.Candidate)
                    .WithMany()
                    .HasForeignKey(c => c.CandidateId)
                    .OnDelete(DeleteBehavior.Cascade);
            }
        }
}
