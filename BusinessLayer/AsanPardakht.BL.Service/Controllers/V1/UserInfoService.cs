using AsanPardakht.BL.Core;
using AsanPardakht.CL.DTOs;
using AsanPardakht.CL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;


namespace AsanPardakht.BL.Service.Controllers
{
    //Change in Master
    //Chnage in testb
    //Change in testb to merge
    //[Route("[controller]")]
    [ApiVersion("1.0")]
    public class UserInfoService : BaseApiController
    {
        protected readonly IUserInfo _UserInfo;
        public UserInfoService(ILogger<BaseApiController> logger, IUserInfo UserInfo) : base(logger)
        {
            _UserInfo = UserInfo;
        }


        #region User
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> FilterUsers(UserDTO_request user, int pageNumber, int PageSize)
        {
            Response.StatusCode = StatusCodes.Status200OK;
            return Ok(await _UserInfo.FilterUsers(user, pageNumber, PageSize));
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetUserByID(int Id)
        {
            Response.StatusCode = StatusCodes.Status200OK;
            return Ok(await _UserInfo.GetUserByID(Id));
        }

        [HttpDelete]
        [Route("[action]")]
        public async Task<IActionResult> DeleteUser(int Id)
        {
            Response.StatusCode = StatusCodes.Status202Accepted;
            return Ok(await _UserInfo.DeleteUser(Id));
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateUser(UserDTO_response user)
        {
            Response.StatusCode = StatusCodes.Status202Accepted;
            return Ok(await _UserInfo.UpdateUser(user));
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateUser(UserDTO_request user)
        {
            Response.StatusCode = StatusCodes.Status201Created;
            return Ok(await _UserInfo.CreateUser(user));
        }

        #endregion


        #region UserAddress
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> FilterUserAddress(UserAddressDTO_request user, int pageNumber, int PageSize)
        {
            Response.StatusCode = StatusCodes.Status200OK;
            return Ok(await _UserInfo.FilterUserAddress(user, pageNumber, PageSize));
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetUserAddressByID(int Id)
        {
            Response.StatusCode = StatusCodes.Status200OK;
            return Ok(await _UserInfo.GetUserAddressByID(Id));
        }

        [HttpDelete]
        [Route("[action]")]
        public async Task<IActionResult> DeleteAddressUser(int Id)
        {
            Response.StatusCode = StatusCodes.Status202Accepted;
            return Ok(await _UserInfo.DeleteUserAddress(Id));
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateUserAddress(UserAddressDTO_response user)
        {
            Response.StatusCode = StatusCodes.Status202Accepted;
            return Ok(await _UserInfo.UpdateUserAddress(user));
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateUserAddress(UserAddressDTO_request user)
        {
            Response.StatusCode = StatusCodes.Status201Created;
            return Ok(await _UserInfo.CreateUserAddress(user));
        }

        #endregion





    }
}
