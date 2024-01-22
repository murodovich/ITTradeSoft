using ITTradeSoft.Domain.Entities.ProjectCalculations;
using ITTradeSoft.Domain.Entities.Projects;
using ITTradeSoft.Domain.Entities.Question;
using Microsoft.EntityFrameworkCore;

namespace ITTradeSoft.Application.Absreactions
{
    public interface ITradeSoftDBContext
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<Questions> Questions { get; set; }
        public DbSet<ProjectCalculator> ProjectCalculations { get; set; }
    
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
