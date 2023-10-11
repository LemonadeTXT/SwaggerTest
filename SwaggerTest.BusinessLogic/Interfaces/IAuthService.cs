using SwaggerTest.Common.DTOs;

namespace SwaggerTest.BusinessLogic.Interfaces
{
    public interface IAuthService
    {
        string Login(UserAuthDto userAuthDto);

        bool Register(UserCreateDto userCreateDto);
    }
}
