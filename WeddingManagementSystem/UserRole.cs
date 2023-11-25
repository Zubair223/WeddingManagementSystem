using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingManagementSystem
{
    class UserRole
    {
        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public string RoleDisplay { get; set; }
        public bool IsSuperAdmin { get; set; }
        public bool Admin { get; set; }
        public bool IsWaza { get; set; }
        public bool IsParent { get; set; }
        public bool IsActive { get; set; }
    }
}
