using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingManagementSystem
{
    /// <summary>
    /// This class is the main entity class contains every property of the user but if we want user to deal with some of the property why we will send whole class instead that MS has given us a choice of making DTO (Data Transfer Object) means breaking down of entity into small models and properties arranged acc to the functionality.
    /// </summary>
        class UserRegistration : CommonField
        {
            public int UserID { get; set; }
            public int RoleID { get; set; }
            public string FirstName { get; set; }
            public string MiddleName { get; set; }
            public string LastName { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }
            public string Gender { get; set; }
            public string Address { get; set; }
            public string Number { get; set; }
        
        }
    /// <summary>
    /// This is DTO containing common properties that can be used in the other DTO
    /// </summary>
    class CommonUserDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Number { get; set; }
    }
    /// <summary>
    /// Post Means create
    /// </summary>
    class PostUserDTO : CommonUserDTO
    {
        

    }
    /// <summary>
    /// Put means update
    /// </summary>
    class PutUserDTO : PostUserDTO
    {
        public int RoleID { get; set; }
    }
    /// <summary>
    /// List means Show select
    /// </summary>
    class ListUserDTO :PutUserDTO
    {
        
    }
    /// <summary>
    /// Delete is delete the record from the DB
    /// </summary>
    class DeleteUserDTO
    {
        public int UserID { get; set; }
        public int RoleID { get; set; }
    }
}
