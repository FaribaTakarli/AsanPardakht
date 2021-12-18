using AsanPardakht.BL.Core.Config;
using AsanPardakht.CL.DTOs;
using AsanPardakht.CL.Entities;
using AsanPardakht.DAL.SQL;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AsanPardakht.BL.Core
{
    public class UserInfoHandler : IUserInfo
    {

        private readonly IUnitOfWork db;
        private readonly IMapper _mapper;
        public UserInfoHandler( )
        {
            IDBFactory dBFactory = new SQLDBFactory();
            db = dBFactory.GetDB() as IUnitOfWork;
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });
            IMapper mapper = mapperConfig.CreateMapper();
            _mapper = mapper;
        }

        #region User
        public async Task<UserDTO_response> GetUserByID(int Id)
        {
            var res = await db.UserRepository.GetByIDAsync(Id);
            return _mapper.Map<UserDTO_response>(res);
        }
        public  async Task<int> DeleteUser(int Id)
        {
            db.UserRepository.Delete(Id);
            await db.SaveAsync();
            return Id;
        }
        public async Task<int> UpdateUser(UserDTO_response user)
        {
            var _user = _mapper.Map<User>(user);
            db.UserRepository.Update(_user);
            await db.SaveAsync();
            return _user.Id;
        }
        public async Task<int> CreateUser(UserDTO_request user)
        {
            var _user = _mapper.Map<User>(user);
            db.UserRepository.Insert(_user);
            await db.SaveAsync();
            return _user.Id;
        }      
        public async Task<IEnumerable<UserDTO_response>> FilterUsers(UserDTO_request user, int pageNumber, int pageSize)
        {
            int rowNumber = (pageNumber - 1) * pageSize;           
            var result = db.UserRepository.Get(rowNumber, pageSize, FilterByUserDTO(user), u => u.OrderBy(o => o.Name));
            return result.Select(x => _mapper.Map<UserDTO_response>(x));
        }
        Expression<Func<User, bool>> FilterByUserDTO(UserDTO_request user)
        {
                return x => x.Name.Contains(user.Name);           
        }

        #endregion


        #region UserAddress     
        public async Task<IEnumerable<UserAddressDTO_response>> FilterUserAddress(UserAddressDTO_request userAddress, int pageNumber, int pageSize)
        {
            int rowNumber = (pageNumber - 1) * pageSize;
            var result = db.UserAddressRepository.Get(rowNumber, pageSize, FilterByUserAddressDTO(userAddress), u => u.OrderBy(o => o.UserId));
            return result.Select(x => _mapper.Map< UserAddressDTO_response >(x));


        }
        public async Task<UserAddressDTO_response> GetUserAddressByID(int Id)
        {
            var res = await db.UserAddressRepository.GetByIDAsync(Id);
            return _mapper.Map<UserAddressDTO_response>(res);
        }
        public async Task<int> DeleteUserAddress(int Id)
        {
            db.UserAddressRepository.Delete(Id);
            await db.SaveAsync();
            return Id;
        }
        public async Task<int> UpdateUserAddress(UserAddressDTO_response user)
        {
            var _user = _mapper.Map<UserAddress>(user);
            db.UserAddressRepository.Update(_user);
            await db.SaveAsync();
            return _user.Id;
        }
        public async Task<int> CreateUserAddress(UserAddressDTO_request user)
        {
            var _user = _mapper.Map<UserAddress>(user);
            db.UserAddressRepository.Insert(_user);
            await db.SaveAsync();
            return _user.Id;
        }
        Expression<Func<UserAddress, bool>> FilterByUserAddressDTO(UserAddressDTO_request userAddress)
        {
            return x => x.Province.Contains(userAddress.Province) &&
            x.City.Contains(userAddress.City) &&
            x.Address.Contains(userAddress.Address) &&
            (userAddress.UserId != 0 ? x.UserId == userAddress.UserId : true);
                 
        }

        #endregion

    }
}
