using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DataAccess
{
    public class PostgresDbContext: AppDbContext
    {
        public PostgresDbContext(IConfiguration configuration): base(configuration)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql(_configuration.GetConnectionString("PostgresConnectionString"));
        }
    }
}