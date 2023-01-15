using GymRatApi.Entieties;

namespace GymRatApi.Commands.TrainingPartCommands
{
    public class TrainingPartUpdateCommand
    {
        public int Id { get; set; }
        public int AmountSeries { get; set; }
        public int Reps { get; set; }
        public int BodyWeight { get; set; }
        public int BreakBetweenSeries { get; set; }
    }
}
