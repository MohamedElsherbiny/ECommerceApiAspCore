using System.ComponentModel.DataAnnotations;

namespace ApiDesign.Dtos
{
    public class UserForRegisterDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}