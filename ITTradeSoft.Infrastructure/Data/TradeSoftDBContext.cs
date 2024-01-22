using ITTradeSoft.Application.Absreactions;
using ITTradeSoft.Domain.Entities.Address;
using ITTradeSoft.Domain.Entities.ProjectCalculations;
using ITTradeSoft.Domain.Entities.Projects;
using ITTradeSoft.Domain.Entities.Question;
using Microsoft.EntityFrameworkCore;

namespace ITTradeSoft.Infrastructure.Data
{
    public class TradeSoftDBContext : DbContext,ITradeSoftDBContext
    {
        public TradeSoftDBContext(DbContextOptions<TradeSoftDBContext> options) : base(options)
        {
            
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Questions> Questions { get; set; }
        public DbSet<ProjectCalculator> ProjectCalculations { get; set; }
        public DbSet<Addres> Address {  get; set; }




    }
}
