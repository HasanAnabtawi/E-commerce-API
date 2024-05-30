using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StoreAPI.Models;

namespace StoreAPI.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<CartModel> Carts { get; set; }

        public DbSet<OrderModel> Orders { get; set; }
        public DbSet<OrderItemsModel> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var hasher = new PasswordHasher<IdentityUser>();

            var adminRole = new IdentityRole
            {
                Id = "fceb3ed0-9187-4188-9f9d-3361fdd61912",
                Name = "Admin",
                ConcurrencyStamp = null,
                NormalizedName = "ADMIN"

            };
            var userRole = new IdentityRole
            {
                Id = "a7fa3c4d-5ef4-4f70-b0f1-c84bec1f6edb",
                Name = "User",
                ConcurrencyStamp = null,
                NormalizedName = "USER"

            };
            modelBuilder.Entity<IdentityRole>().HasData(adminRole, userRole);
            var adminUser = new IdentityUser
            {
                Id = "fa78427d-79a1-4fff-8b6f-1904a7e6fd10",
                UserName = "Hasan",
                NormalizedUserName = "HASAN",
                Email = "Hasan@email.com",
                NormalizedEmail = "HASAN@EMAIL.COM",
                PasswordHash = "AQAAAAIAAYagAAAAEBIv3dU533E4UmSo35Fu2uZx8xQFSZ0obFsoWErZMjHepZUn/IVD6UHHx09juNxvag==",
                SecurityStamp= "6f9c54a3-e406-44cd-822f-6b9202dd0894",
                ConcurrencyStamp = "6989e506-d51b-4395-b6b8-1a5a079295b0"
            };
            modelBuilder.Entity<IdentityUser>().HasData(adminUser);
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = adminRole.Id,
                UserId = adminUser.Id,
            });

           









            base.OnModelCreating(modelBuilder);


        }



    }
}
