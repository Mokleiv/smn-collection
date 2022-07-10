using HomeAPI.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace HomeAPI.Data.ApplicationDbContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Workout>()
                .HasKey(x => new { x.WorkoutProgramId, x.ExersiceId });

            modelBuilder
                .Entity<WorkoutFocus>()
                .HasKey(x => new { x.WorkoutProgramId, x.MuscleFocusId });
        }

        public DbSet<Exercise> Exercises { get; set; } = default!;
        public DbSet<MuscleFocus> MuscleFocuses { get; set; } = default!;
        public DbSet<WorkoutProgram> WorkoutPrograms { get; set; } = default!;
    }
}
