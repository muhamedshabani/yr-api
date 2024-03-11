using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using yr_api.Models.Entities;

namespace yr_api.Data;

public class DatabaseContext : IdentityDbContext<ApplicationUser>
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

    public DbSet<ApplicationUser> AppUsers { get; set; }
    public DbSet<Cabinet> Cabinets { get; set; }
    public DbSet<Models.Entities.File> Files { get; set; }
    public DbSet<Style> Styles { get; set; }
    public DbSet<Label> Labels { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<ApplicationUser>().HasKey(e => e.Id);
        builder.Entity<Cabinet>(opt =>
        {
            opt.HasKey(x => x.Id);
            opt.HasMany(x => x.Files).WithOne(x => x.Cabinet).HasForeignKey(x => x.CabinetId);
            opt.HasOne(x => x.Styles);
            opt.HasOne(x => x.User);
        });

        base.OnModelCreating(builder);
    }
}
