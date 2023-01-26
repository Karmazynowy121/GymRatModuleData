namespace GymRatApi.Dto
{
    public class TrainingDto
    { 
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime TrainingDate { get; set; }
        public int Interval { get; set; }
        public int TrainingDuration { get; set; } = 0;
        public int TrainingScheuldeId { get; set; }
        public List<TrainingPartDto> TrainingPart { get; set; }

    }
}
