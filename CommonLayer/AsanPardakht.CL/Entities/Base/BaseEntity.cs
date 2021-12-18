using System;
using System.Collections.Generic;
using System.Text;

namespace AsanPardakht.CL.Entities.Base
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            DateInserted = DateTime.Now;
        }

        //[Display(Name = "شناسه")]
        public int Id { get; set; }

        //[Display(Name = "تاریخ ایجاد")]
        public DateTime DateInserted { get; set; }

        //[Display(Name = "تاریخ آخرین تغییر")]
        //public DateTime? DateModified { get; set; }

    }
}
