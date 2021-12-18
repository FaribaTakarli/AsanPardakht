using AsanPardakht.CL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AsanPardakht.DAL.SQL
{
    public interface IUnitOfWork
    {
        GenericRepository<User> UserRepository { get; }

        GenericRepository<UserAddress> UserAddressRepository { get;  }
         void Save();
         Task<int> SaveAsync();
         void Dispose();
    }
}
