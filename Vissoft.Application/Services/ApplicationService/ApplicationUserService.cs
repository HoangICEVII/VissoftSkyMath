using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.DTOs.User;
using Vissoft.Core.Interfaces.IRepository;
using Vissoft.Core.Interfaces.IService.IApplicationService;

namespace Vissoft.Application.Services.ApplicationService
{
    public class ApplicationUserService : IApplicationUserService
    {
        private readonly IUserRepository _userRepository;
        public ApplicationUserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<UserAuthenDto> LoginViaForm(UserLoginViaFormDto userlogin)
        {
            return await _userRepository.LoginViaForm(userlogin);
        }

        public async Task<UserAuthenDto> LoginViaGoogle(UserLoginViaGoogleDto userLoginViaGoogleDto)
        {
            return await _userRepository.LoginViaGoogle(userLoginViaGoogleDto);
        }

        public async Task Register(UserRegisterDto userRegisterDto)
        {
            await _userRepository.Register(userRegisterDto);
        }
    }
}
