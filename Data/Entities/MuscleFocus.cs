using HomeAPI.Common.Interface;

namespace HomeAPI.Data.Entities
{
    public class MuscleFocus : IEntityBase
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTimeOffset CreatedDate { get; set; } = DateTimeOffset.Now;
        public string Name { get; set; }
        public ICollection<WorkoutFocus> WorkoutFocuses { get; set; } =
            new List<WorkoutFocus>();
    }
}
