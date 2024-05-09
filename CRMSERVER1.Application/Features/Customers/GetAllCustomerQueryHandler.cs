using CRMSERVER1.Domain.Entities;
using CRMSERVER1.Domain.Repositories;
using GenericRepository;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CRMSERVER1.Application.Features.Customers;

internal sealed class GetAllCustomerQueryHandler(ICustomerRepository customerRepository, IUnitOfWork unitOfWork) : IRequestHandler<GetAllCustomerQuery,List<Customer>>
{
    public async Task<List<Customer>> Handle(GetAllCustomerQuery request, CancellationToken cancellationToken)
    {
        List<Customer> customers = await customerRepository.GetAll().ToListAsync(cancellationToken);

        return customers;
    }

    
}
