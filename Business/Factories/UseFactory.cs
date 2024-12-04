using Business.Dtos;
using Business.Helpers;
using Business.Models;

namespace Business.Factories
{
    public static class UserFactory
    {
        public static UserRegistrationForm Create()
        {
            return new UserRegistrationForm();
        }

        public static User Create(UserRegistrationForm form)
        {
            return new User
            {
                Id = UniqueIdentifierGenerator.Generate(),
                FirstName = form.FirstName,
                LastName = form.LastName,
                Email = form.Email,
                PhoneNumber = form.PhoneNumber,
                Address = form.Address,
                PostalCode = form.PostalCode,
                City = form.City    
            };
        }
    }
}
