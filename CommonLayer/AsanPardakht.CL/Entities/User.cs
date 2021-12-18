using AsanPardakht.CL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace AsanPardakht.CL.Entities
{
    public class User: BaseEntity
    {
        //[Display(Name = "نام کاربر")]
        public string Name { get; set; }
        public ICollection<UserAddress> userAddresses { get; set; }
    }
}
