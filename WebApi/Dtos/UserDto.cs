using WebApi.Models;

namespace WebApi.Dtos
{
    public class UserDto
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public Address Address { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}