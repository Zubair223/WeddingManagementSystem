using System;
using System.Collections.Generic;

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
            PostUserDTO post = new PostUserDTO();
            post.FirstName = "Zubair";
            post.MiddleName = "Altaf";
            post.LastName = "Rangrez";
            post.Gender = "Male";
            post.UserName = "abc";
            post.Password = "abc@123";
            post.Number = "990839383";
            post.Address = "Ellahi Bagh";
            PutUserDTO put = new PutUserDTO();
            put.UserID = 01;
            put.FirstName = "Zubair";
            put.MiddleName = "Altaf";
            put.LastName = "Rangrez";
            put.Gender = "Male";
            put.UserName = "abc";
            put.Password = "abc@123";
            put.Number = "990839383";
            put.Address = "Ellahi Bagh";
            UserAction action = new UserAction();


            List<PostUserDTO> listuser = new List<PostUserDTO>();
            ///
            listuser.Add(post);
            listuser.Add(post);

           /// listuser.Add(action);


            action.Create(post);
            action.Update(put);

        }
    }
}
