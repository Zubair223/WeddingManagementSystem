using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingManagementSystem
{
    interface IActionSaveUpdate
    {
        public int Create(PostUserDTO post);
        public int Update();
    }
}
