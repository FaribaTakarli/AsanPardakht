using AsanPardakht.CL.Entities;
using AsanPardakht.DAL.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AsanPardakht.DAL.SQL
{ 
    public class UnitOfwork :IUnitOfWork, IDisposable 
    {
        private APDB context = new APDB();
        private GenericRepository<User> userRepository;
        private GenericRepository<UserAddress> userAddressRepository;

         GenericRepository<User> IUnitOfWork.UserRepository
        {
            get
            {

                if (this.userRepository == null)
                {
                    this.userRepository = new GenericRepository<User>(context);
                }
                return userRepository;
            }
        }

        GenericRepository<UserAddress> IUnitOfWork.UserAddressRepository
        {
            get
            {

                if (this.userAddressRepository == null)
                {
                    this.userAddressRepository = new GenericRepository<UserAddress>(context);
                }
                return userAddressRepository;
            }
        }

       
        public void Save()
        {
            context.SaveChanges();
        }
        public async Task<int> SaveAsync()
        {
          return await context.SaveChangesAsync();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
