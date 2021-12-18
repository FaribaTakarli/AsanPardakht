using AsanPardakht.CL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace AsanPardakht.CL.DTOs
{
    public class UserAddressDTO_response : BaseEntityDTO
    {
        public string Province { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public int UserId { get; set; }



    }
}
