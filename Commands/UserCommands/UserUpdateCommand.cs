﻿namespace GymRatApi.Commands.UserCommands
{
    public class UserUpdateCommand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime UpdateAt { get; set; }
        
        
    }
}
