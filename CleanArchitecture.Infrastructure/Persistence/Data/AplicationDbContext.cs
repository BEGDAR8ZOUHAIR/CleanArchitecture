using Microsoft.EntityFrameworkCore;


namespace CleanArchitecture.Infrastructure.Persistence.Data
{
    internal class AplicationDbContext: DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {
                
            
        }
    }
}
