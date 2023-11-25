using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingManagementSystem
{
    class Waza
    {
        public int WazaID { get; set; }
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Prefix { get; set; }
        public string Gender { get; set; }
        public string PermanentAddress { get; set; }
        public string Latitude { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }
        public DateTime EstbYear { get; set; }
        public int YearExperience { get; set; }
    }
}
