using MinimalAPI.Models;

namespace MinimalAPI.Repositories
{
    interface ICustomerRepository
    {
        void Create(Customer customer);
        Customer GetById(Guid id);
        List<Customer> GetAll();
        void Update(Customer customer);
        void Delete(Guid id);
    }
    class CustomerRepository : ICustomerRepository
    {
        private readonly Dictionary<Guid, Customer> _customers = new();

        public void Create(Customer customer)
        {
            if (customer is null)
            {
                return;
            }

            _customers[customer.Id] = customer;
        }

        public Customer GetById(Guid id) => _customers[id];

        public List<Customer> GetAll() => _customers.Values.ToList();

        public void Update(Customer customer)
        {
            var existingCustomer = GetById(customer.Id);
            if (existingCustomer is null) return;

            _customers[customer.Id] = customer;
        }

        public void Delete(Guid id) => _customers.Remove(id);
    }
}
