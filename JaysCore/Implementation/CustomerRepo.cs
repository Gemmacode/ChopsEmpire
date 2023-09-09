using JaysCore.Service;
using JaysData.DTO;
using JaysData.Entitties;
using JaysData.MyDbContext;

namespace JaysCore.Implementation
{
    public class CustomerRepo : ICustomerRepo
    {
        private readonly UserDbContext _userDbContext;

        public CustomerRepo(UserDbContext userDbContext)
        {
            _userDbContext = userDbContext;
        }
        public void CreateCustomer(CreateCustomerDTO createCustomerDTO)
        {
            var result = new Customer()
            {
                Id = Guid.NewGuid().ToString(),
                Name = createCustomerDTO.Name,
                Address = createCustomerDTO.Address,
                Email = createCustomerDTO.Email,    
                PhoneNumber = createCustomerDTO.PhoneNumber,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                IsDeleted   = false,
            };
            _userDbContext.Add(result);
            _userDbContext.SaveChanges();
        }

        public Customer GetCustomerById(string id)
        {
            var result = _userDbContext.Customers1.SingleOrDefault(x => x.Id == id);
            return result;
        }

        public void DeleteCustomerById(string id)
        {
            var result = _userDbContext.Customers1.SingleOrDefault(x => x.Id == id);
            _userDbContext.Customers1.Remove(result);
            _userDbContext.SaveChanges();
        }

       
    }
}
