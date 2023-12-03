using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.DTOs.User;
using Vissoft.Core.Entities;
using Vissoft.Core.Interfaces.IRepository;
using Vissoft.Infrastructure.Identity;

namespace Vissoft.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IMapper _mapper;

        public async Task<UserAuthenDto> LoginViaForm(UserLoginViaFormDto userlogin)
        {
            var userInfo = await _userManager.FindByNameAsync(userlogin.UserName);
            if (userInfo != null && await _userManager.CheckPasswordAsync(userInfo, userlogin.Password))
            {
                return new UserAuthenDto() {
                    UserName = userInfo.UserName,
                    Email = userInfo.Email,
                    Role = (await _userManager.GetRolesAsync(userInfo)).FirstOrDefault()
            };
            }
            else
            {
                throw new Exception("tai khoan khong ton tai");
            }
        }

        public async Task<UserAuthenDto> LoginViaGoogle(UserLoginViaGoogleDto userLoginViaGoogleDto)
        {
            var userInfo = await _userManager.FindByEmailAsync(userLoginViaGoogleDto.Email);
            if(userInfo == null)
            {
                await Register(new UserRegisterDto()
                {
                    Name = userLoginViaGoogleDto.Name,
                    Email = userLoginViaGoogleDto.Email,
                });
            }
            return new UserAuthenDto()
            {
                UserName = userInfo.UserName,
                Email = userInfo.Email,
                Role = (await _userManager.GetRolesAsync(userInfo)).FirstOrDefault()
            };
        }

        public async Task Register(UserRegisterDto userRegisterDto)
        {
            var userInfo = await _userManager.FindByNameAsync(userRegisterDto.Username);
            if (userInfo != null)
            {
                throw new Exception("ten dang nhap khong kha dung");
            }
            userInfo = await _userManager.FindByEmailAsync(userRegisterDto.Email);
            if (userInfo != null)
            {
                throw new Exception("email da duoc dang ky");
            }
            ApplicationUser user = new ApplicationUser() {
                FullName = userRegisterDto.Name,
                Email = userRegisterDto.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = userRegisterDto.Username
            };
            var result = await _userManager.CreateAsync(user, userRegisterDto.Password);
            if (!result.Succeeded)
            {
                throw new Exception("dang ky khong thanh cong");
            }
        }
    }
}
