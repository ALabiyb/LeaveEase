using Microsoft.AspNetCore.Identity;

namespace LeaveEase.Data
{
    public class Employee : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int UserNameChangeLimit { get; set; } = 10;
        public byte ProfilePicture { get; set; }
    }
}
