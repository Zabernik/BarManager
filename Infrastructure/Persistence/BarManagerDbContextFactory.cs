using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infrastructure.Persistence
{
    public class BarManagerDbContextFactory : IDesignTimeDbContextFactory<BarManagerDbContext>
    {
        public BarManagerDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BarManagerDbContext>();
            optionsBuilder.UseSqlite("Data Source=bar_manager.db");

            return new BarManagerDbContext(optionsBuilder.Options);
        }
    }
}
