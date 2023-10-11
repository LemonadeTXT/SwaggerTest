using SwaggerTest.Common.DTOs;
using SwaggerTest.Models.Models;

namespace SwaggerTest.BusinessLogic.Interfaces
{
    public interface IUserService
    {
        List<UserDto> GetAll();

        UserDto Get(Identifier identifier);

        User Get(UserAuthDto userAuthDto);

        bool Create(UserCreateDto userCreateDto);

        void Update(UserUpdateDto userUpdateDto);

        void Delete(Identifier identifier);
    }
}
