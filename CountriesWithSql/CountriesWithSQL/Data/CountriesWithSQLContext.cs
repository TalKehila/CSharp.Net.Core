using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CountriesWithSQL.Models;

namespace CountriesWithSQL.Data
{
    public class CountriesWithSQLContext : DbContext
    {
        public CountriesWithSQLContext (DbContextOptions<CountriesWithSQLContext> options)
            : base(options)
        {
        }

        public DbSet<CountriesWithSQL.Models.Country> Country { get; set; } = default!;
    }
}
