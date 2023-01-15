﻿

namespace GymRatApi.Dto
{
    public class VideoDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Path { get; set; }

        public int ExerciseId { get; set; }
        public ExerciseDto Exercise { get; set; }
    }
}
