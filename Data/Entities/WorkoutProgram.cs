using HomeAPI.Common.Interface;

namespace HomeAPI.Data.Entities
{
    public class WorkoutProgram : IEntityBase
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTimeOffset CreatedDate { get; set; } = DateTimeOffset.Now;
        public string Name { get; set; }
        public bool IsActive { get; set; } = false;
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset? EndDate { get; set; }
        public ICollection<Workout> Workouts { get; set; } =
            new List<Workout>();
        public ICollection<WorkoutFocus> WorkoutFocuses { get; set; } =
            new List<WorkoutFocus>();
    }
}
