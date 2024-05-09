using CRMSERVER1.Domain.Entities;
using CRMSERVER1.Domain.Repositories;
using CRMSERVER1.Infrastructure.Context;
using GenericRepository;

namespace CRMSERVER1.Infrastructure.Repositories;
internal sealed class CustomerRepository : Repository<Customer, ApplicationDbContext>, ICustomerRepository
{
    public CustomerRepository(ApplicationDbContext context) : base(context)
    {
    }
}
