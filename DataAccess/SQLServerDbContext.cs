using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DataAccess
{
    public class SQLServerDbContext: AppDbContext
    {
        public SQLServerDbContext(IConfiguration configuration): base(configuration)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(_configuration.GetConnectionString("SQLServerConnectionString"));
        }
    }
}