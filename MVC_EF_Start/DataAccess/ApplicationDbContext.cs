using Microsoft.EntityFrameworkCore;
using MVC_EF_Start.Models;

namespace MVC_EF_Start.DataAccess
{
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Company> Companies { get; set; }
    public DbSet<Quote> Quotes { get; set; }

        public DbSet<Candidate_Master> Candidate_Masters { get; set; }
        public DbSet<Committee_Master> Committee_Masters { get; set; }
        public DbSet<ContributionByIndividual> ContributionByIndividuals { get; set; }
        public DbSet<ContributionByCommittee> ContributionByCommittees { get; set; }

    }
}