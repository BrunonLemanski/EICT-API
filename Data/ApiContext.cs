using eict_api.Models;
using Microsoft.EntityFrameworkCore;

namespace eict_api.Data
{
    public class ApiContext : DbContext
    {
        public DbSet<PackageType> PackageTypes { get; set; }

    }
}
