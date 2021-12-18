using AsanPardakht.CL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace AsanPardakht.CL.Entities
{
    public class UserAddress:BaseEntity
    {
        public string Province { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public int UserId { get; set; }
        virtual public User user { get; set; }



    }
}
