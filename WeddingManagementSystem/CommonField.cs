using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingManagementSystem
{
    class CommonField
    {
        public int FieldID { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int DeletedBy { get; set; }
        public DateTime DeletedOn { get; set; }
        public bool IsCreated { get; set; }
        public bool IsModified { get; set; }
        public bool IsDeleted { get; set; }
    }
}
