using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilitis.Results;
using Core.Utilitis.Security.JWT;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IDataResult<User> UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
