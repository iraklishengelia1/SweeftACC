using Microsoft.EntityFrameworkCore;

public class AppContext : DbContext
    {
        public AppContext (DbContextOptions<AppContext> options)
            : base(options)
        {
        }

        public DbSet<EntityFrameworkApp.Models.Teacher> Teacher { get; set; } = default!;
        public DbSet<EntityFrameworkApp.Models.Pupil> Pupil { get; set; } = default!;
    }
