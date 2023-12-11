using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vissoft.Core.DTOs.User;

namespace Vissoft.Core.Interfaces.IService.IApplicationService
{
    public interface IUserService
    {
        public Task<UserAuthenDto> LoginViaForm(UserLoginViaFormDto userlogin);
        public Task<UserAuthenDto> LoginViaGoogle(UserLoginViaGoogleDto userLoginViaGoogleDto);
        public Task Register(UserRegisterDto userRegisterDto);
    }
}
