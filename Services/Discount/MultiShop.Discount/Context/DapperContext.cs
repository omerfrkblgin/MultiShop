using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MultiShop.Discount.Entities;
using System.Data;

namespace MultiShop.Discount.Context
{
    public class DapperContext : DbContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public DapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-S6RRFKJ0\\SQLEXPRESS01;initial Catalog=MultiShopDiscountDb;integrated Security=true;");
        }

        public DbSet<Coupon> Coupons { get; set; }

        public IDbConnection CreateConnectiom() => new SqlConnection(_connectionString);
    }
}
