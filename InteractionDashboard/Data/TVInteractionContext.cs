using Microsoft.EntityFrameworkCore;
using TVInteractionDashboard.Data;

public class TVInteractionContext : DbContext
{
    public TVInteractionContext(DbContextOptions<TVInteractionContext> options) : base(options) { }

    public DbSet<TV_Plant> TV_Plants { get; set; }
    public DbSet<TV_Location> TV_Locations { get; set; }
    public DbSet<TV_Unit> TV_Units { get; set; }
    public DbSet<TV_Interaction> TV_Interactions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // Set up relationships and keys
        modelBuilder.Entity<TV_Plant>()
            .HasKey(p => p.PlantID);

        modelBuilder.Entity<TV_Location>()
            .HasKey(l => l.LocationID);
        modelBuilder.Entity<TV_Location>()
            .HasOne(l => l.Plant)
            .WithMany(p => p.Locations)
            .HasForeignKey(l => l.PlantID);

        modelBuilder.Entity<TV_Unit>()
            .HasKey(u => u.UnitID);
        modelBuilder.Entity<TV_Unit>()
            .HasOne(u => u.Location)
            .WithMany(l => l.Units)
            .HasForeignKey(u => u.LocationID);

        // No primary key on TV_Interaction
        modelBuilder.Entity<TV_Interaction>()
            .HasNoKey();
        // modelBuilder.Entity<TV_Interaction>()
           // .HasOne(i => i.Unit);
           // .WithMany(u => u.Interactions)
          //  .HasForeignKey(i => i.UnitID);
    }
}
