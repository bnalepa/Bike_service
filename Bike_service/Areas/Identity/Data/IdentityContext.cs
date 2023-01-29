using Bike_service.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bike_service.Areas.Identity.Data;

public class IdentityContext : IdentityDbContext<AppUser>
{
    
    public IdentityContext(DbContextOptions<IdentityContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        //builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
        builder.Entity<IdentityRole>().HasData
           (
           new IdentityRole()
           {
               Id = "ef01e7aa-fadb-4488-b751-175f3959cedb",
               Name = "Administrator",
               ConcurrencyStamp = "1",
               NormalizedName = "ADMINISTRATOR"
           }
           );
        var hashing = new PasswordHasher<AppUser>();
        builder.Entity<AppUser>().HasData
            (
            new AppUser()
            {
                Id = "2c5e174e-3b0e-446f-86af-483d56fd7210",
                EmailConfirmed = true,
                Email = "bnalepa@o2.pl",
                NormalizedEmail = "BNALEPA@O2.PL",
                LockoutEnabled = true,
                UserName = "bnalepa@o2.pl",
                NormalizedUserName = "bnalepa@o2.pl",
                PasswordHash = hashing.HashPassword(null, "zaq1@WSX")
            }
            );
        builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = "ef01e7aa-fadb-4488-b751-175f3959cedb",
                UserId = "2c5e174e-3b0e-446f-86af-483d56fd7210"
            }
            );
    }
    //public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<AppUser>
    //{
    //    public void Configure(EntityTypeBuilder<AppUser> builder)
    //    {
    //        builder.Property(u => u.FirstName).HasMaxLength(255);
    //        builder.Property(u => u.LastName).HasMaxLength(255);
    //        builder.Property(u => u.Phone).HasMaxLength(9);
    //    }
    //}
}
