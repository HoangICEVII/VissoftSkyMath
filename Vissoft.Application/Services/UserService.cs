using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.DTOs.User;
using Vissoft.Core.Interfaces.IRepository;
using Vissoft.Core.Interfaces.IService.IApplicationService;

namespace Vissoft.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository) {
            _userRepository = userRepository;
        }
        public async Task<UserAuthenDto> LoginViaForm(UserLoginViaFormDto userlogin)
        {
            return await _userRepository.LoginViaForm(userlogin);
        }

        public async Task<UserAuthenDto> LoginViaGoogle(UserLoginViaGoogleDto userLoginViaGoogleDto)
        {
            throw new NotImplementedException();
        }

        public async Task Register(UserRegisterDto userRegisterDto)
        {
            await _userRepository.Register(userRegisterDto);
        }
    }
}
