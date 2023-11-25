using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingManagementSystem
{
    class Child
    {
        public int ChildID { get; set; }
        public int UserID { get; set; }
        public int ParentID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string SpouseFistName { get; set; }
        public string SpouseLastName { get; set; }
        public string Qualification { get; set; }
        public int Age { get; set; }
        public string Prefix { get; set; }
        public string Gender { get; set; }
        public string PermanentAddress { get; set; }
    }
}
