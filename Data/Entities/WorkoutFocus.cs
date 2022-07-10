namespace HomeAPI.Data.Entities
{
    public class WorkoutFocus
    {
        public Guid WorkoutProgramId { get; set; }
        public WorkoutProgram? WorkoutProgram { get; set; }
        public Guid MuscleFocusId { get; set; }
        public MuscleFocus? MuscleFocus { get; set; }
    }
}
