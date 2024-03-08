using Api.Interfaces;

namespace Api.Services
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void AddUser(string username)
        {
            _userRepository.AddUser(username);
        }
    }
}
