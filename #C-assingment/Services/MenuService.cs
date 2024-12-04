using Business.Dtos;
using Business.Factories;
using Business.Services;

namespace Business.Services
{
    public class MenuService
    {
        private readonly UserService _userService = new UserService();

        public void CreateUserDialog()
        {
            Console.Clear();

            UserRegistrationForm user = UserFactory.Create();

            Console.Write("Enter your first name: ");
            user.FirstName = Console.ReadLine() ?? string.Empty;

            Console.Write("Enter your last name: ");
            user.LastName = Console.ReadLine() ?? string.Empty;

            Console.Write("Enter your email: ");
            user.Email = Console.ReadLine() ?? string.Empty;

            Console.Write("Enter your phone number: ");
            user.PhoneNumber = Console.ReadLine() ?? string.Empty;

            Console.Write("Enter your address: ");
            user.Address = Console.ReadLine() ?? string.Empty;

            Console.Write("Enter your postal code: ");
            user.PostalCode = Console.ReadLine() ?? string.Empty;

            Console.Write("Enter your city: ");
            user.City = Console.ReadLine() ?? string.Empty;

            _userService.Add(UserFactory.Create(user));
        }
    }
}
