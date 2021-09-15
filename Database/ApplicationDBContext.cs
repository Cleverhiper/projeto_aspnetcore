using Microsoft.EntityFrameworkCore;

namespace projeto_aspnetcore.Database
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        
    }
}