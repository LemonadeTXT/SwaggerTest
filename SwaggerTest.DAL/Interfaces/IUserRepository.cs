using SwaggerTest.Common.DTOs;
using SwaggerTest.Models.Models;

namespace SwaggerTest.DAL.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();

        User Get(Identifier identifier);

        User Get(UserAuthDto userAuthDto);

        void Create(User user);

        void Update(User user);

        void Delete(Identifier identifier);

        bool IsCreated(string email);
    }
}
