using System;
using System.Collections.Generic;
using System.Text;
using ReCapProject.Core.Entities.Concrete;
using ReCapProject.Core.Utilities.Results;
using ReCapProject.Core.Utilities.Security.Jwt;
using ReCapProject.Entities.Dtos;

namespace ReCapProject.Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
