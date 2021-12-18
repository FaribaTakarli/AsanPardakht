using System;
using System.Collections.Generic;
using System.Text;

namespace AsanPardakht.CL.DTOs
{
    public class BaseEntityDTO
    {
        public BaseEntityDTO()
        {
            DateInserted = DateTime.Now;
        }

        public int Id { get; set; }

        //[Display(Name = "تاریخ ایجاد")]
        public DateTime DateInserted { get; set; }

        //[Display(Name = "تاریخ آخرین تغییر")]
        //public DateTime? DateModified { get; set; }

    }
}
