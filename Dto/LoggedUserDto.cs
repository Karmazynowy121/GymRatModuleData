namespace GymRatApi.ModuleData.Dto
{
    public class LoggedUserDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } = "user";
        public string Jwt { get; set; }
    }
}
