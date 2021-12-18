
using AsanPardakht.CL.DTOs;
using AsanPardakht.CL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AsanPardakht.BL.Core
{
    public interface IUserInfo
    {


        #region User
        Task<IEnumerable<UserDTO_response>> FilterUsers(UserDTO_request user, int pageNumber, int pageSize);
        Task<UserDTO_response> GetUserByID(int Id);
        Task<int> DeleteUser(int Id);
        Task<int> UpdateUser(UserDTO_response user);
        Task<int> CreateUser(UserDTO_request user);

        #endregion


        #region UserAddress
        Task<IEnumerable<UserAddressDTO_response>> FilterUserAddress(UserAddressDTO_request user, int pageNumber, int pageSize);
        Task<UserAddressDTO_response> GetUserAddressByID(int Id);
        Task<int> DeleteUserAddress(int Id);
        Task<int> UpdateUserAddress(UserAddressDTO_response user);
        Task<int> CreateUserAddress(UserAddressDTO_request user);

        #endregion



    }
}
