using AutoMapper;
using SwaggerTest.BusinessLogic.Interfaces;
using SwaggerTest.Common.DTOs;
using SwaggerTest.DAL.Interfaces;
using SwaggerTest.Models.Models;

namespace SwaggerTest.BusinessLogic.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public List<UserDto> GetAll()
        {
            var users = _userRepository.GetAll();

            var usersDto = new List<UserDto>();

            foreach (var user in users)
            {
                usersDto.Add(_mapper.Map<UserDto>(user));
            }

            return usersDto;
        }
      
        public UserDto Get(Identifier identifier)
        {
            var user = _userRepository.Get(identifier);

            var userDto = _mapper.Map<UserDto>(user);

            return userDto;
        }

        public User Get(UserAuthDto userAuthDto)
        {
            var user = _userRepository.Get(userAuthDto);

            return user;
        }

        public bool Create(UserCreateDto userCreateDto)
        {
            if (!_userRepository.IsCreated(userCreateDto.Email))
            {
                var user = new User
                {
                    Login = userCreateDto.Login,
                    Password = userCreateDto.Password,
                    Email = userCreateDto.Email,
                    Age = userCreateDto.Age
                };

                _userRepository.Create(user);

                return true;
            }

            return false;
        }

        public void Update(UserUpdateDto userUpdateDto)
        {
            var identifier = new Identifier
            {
                Id = userUpdateDto.Id
            };

            var user = _userRepository.Get(identifier);

            user.Login = userUpdateDto.Login;
            user.Password = userUpdateDto.Password;
            user.Email = userUpdateDto.Email;
            user.Age = userUpdateDto.Age;

            _userRepository.Update(user);
        }

        public void Delete(Identifier identifier)
        {
            _userRepository.Delete(identifier);
        }
    }
}
