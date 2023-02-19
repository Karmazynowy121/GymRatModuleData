namespace GymRatApi.Commands.TrainingCommands
{
    public class TrainingUpdateCommand
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime TrainingDate { get; set; }
        public int Interval { get; set; }
        public int TrainingDuration { get; set; } = 0;
        public int TrainingScheuldeId { get; set; }
    }
}
