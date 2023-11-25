using System;

namespace WeddingManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World!");
            UserRole obj = new();
            obj.RoleID = 1;
            int x = obj.RoleID;
            Console.WriteLine(x);*/
            PostUserDTO obj = new PostUserDTO();
            obj.FirstName = "Zubair";
            obj.MiddleName = "Altaf";
            obj.LastName = "Rangrez";
            obj.Gender = "Male";
            obj.UserName = "abc";
            obj.Password = "abc@123";
            obj.Number = "990839383";
            obj.Address = "Ellahi Bagh";

         
            UserAction action = new UserAction();
            action.Create(obj);

        }
    }
}
