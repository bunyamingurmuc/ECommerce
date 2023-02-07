namespace ECommerce.DTO
{
	public class CCreateAccountDto
	{
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
