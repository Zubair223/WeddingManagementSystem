using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingManagementSystem
{
    class UserAction : IActionSaveUpdate
    {
        public int Create(PostUserDTO post)
        {
            UserRegistration obj = new UserRegistration();

            Console.WriteLine(post.FirstName);
            Console.WriteLine(post.MiddleName);
            Console.WriteLine(post.LastName);
            Console.WriteLine(post.Gender);
            Console.WriteLine(post.UserName);
            Console.WriteLine(post.Password);
            Console.WriteLine(post.Number);
            Console.WriteLine(post.Address);
            return 0; 
        }
        public int Update() 
        {
            return 0;
        }
    }
}
