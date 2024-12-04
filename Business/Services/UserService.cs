using Business.Models;
using Business.Services;

namespace Business.Services
{
    public class UserService
    {
        private List<User> _users = new List<User>();
        private readonly FileService _fileService = new FileService();

        public void Add(User user)
        {
            _users.Add(user);
            _fileService.SaveListToFile(_users);
        }

        public IEnumerable<User> GetAll()
        {
            _users = _fileService.LoadListFromFile();
            return _users;
        }
    }
}
