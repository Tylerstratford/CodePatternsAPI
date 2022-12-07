using CodePatternsAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodePatternsAPI.Data
{
    public class SqlContext : DbContext

    {
        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {

        }

        public DbSet<DressEntity> Dress { get; set; }
        public DbSet<JacketEntity> Jacket { get; set; }
    }
}
