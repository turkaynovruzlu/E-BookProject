using Microsoft.AspNetCore.Identity;
using System;

namespace DATA.Data.Entity
{
    public class User : IdentityUser<int>
    {

        public DateTime DateOfBirth { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Age { get; set; }
        public ICollection<Payment> Payments { get; set; }
        public ICollection<Comment> Comments { get; set; }
        //PhoneNumber ve Email identityuserde var
    }
}
