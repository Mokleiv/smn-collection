using HomeAPI.Common.Enum;
using HomeAPI.Common.Interface;

namespace HomeAPI.Data.Entities
{
    public class Workout
    {
        public Guid WorkoutProgramId { get; set; }
        public WorkoutProgram? WorkoutProgram { get; set; }
        public Guid ExersiceId { get; set; }
        public Exercise? Exersice { get; set; }
        public int Sets { get; set; }
        public int Reps { get; set; }
        public double Weight { get; set; }
        public Day Day { get; set; }
        public DateTimeOffset CreatedDate { get; set; } = DateTimeOffset.Now;
    }
}
