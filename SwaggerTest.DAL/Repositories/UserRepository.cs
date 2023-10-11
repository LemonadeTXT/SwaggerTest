using SwaggerTest.Common.DTOs;
using SwaggerTest.DAL.Interfaces;
using SwaggerTest.Models;
using SwaggerTest.Models.Models;

namespace SwaggerTest.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationContext _applicationContext;

        public UserRepository(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public IEnumerable<User> GetAll()
        {
            var users = _applicationContext.Users.AsQueryable();

            return users;
        }

        public User Get(Identifier identifier)
        {
            var user = _applicationContext.Users.FirstOrDefault(u => u.Id == identifier.Id);

            return user;
        }

        public User Get(UserAuthDto userAuthDto)
        {
            var user = _applicationContext.Users.FirstOrDefault(u => u.Email == userAuthDto.Email);

            return user;
        }

        public async void Create(User user)
        {
            await _applicationContext.Users.AddAsync(user);
            _applicationContext.SaveChanges();
        }

        public void Update(User user)
        {
            _applicationContext.Users.Update(user);
            _applicationContext.SaveChanges();
        }

        public void Delete(Identifier identifier)
        {
            _applicationContext.Users.Remove(Get(identifier));
            _applicationContext.SaveChanges();
        }

        public bool IsCreated(string email)
        {
            var isCreated = _applicationContext.Users.Any(user => user.Email == email);

            return isCreated;
        }
    }
}
