using eict_api.Models.Package.Package;
using Microsoft.EntityFrameworkCore;

namespace eict_api.Data
{
    public class ApiContext : DbContext
    {
        public DbSet<PackageTypeEntity> PackageTypes { get; set; }

    }
}
