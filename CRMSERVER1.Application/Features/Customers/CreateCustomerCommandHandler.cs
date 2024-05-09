using CRMSERVER1.Domain.Entities;
using CRMSERVER1.Domain.Enums;
using CRMSERVER1.Domain.Repositories;
using GenericRepository;
using MediatR;

namespace CRMSERVER1.Application.Features.Customers;

internal sealed class CreateCustomerCommandHandler(ICustomerRepository customerRepository,IUnitOfWork unitOfWork) : IRequestHandler<CreateCustomerCommand>
{
    public async Task Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
    {
        Customer? customer = new()
        {
            BuildName=request.BuildName,
            City=request.City,
            Country=request.Country,
            Street=request.Street,
            Town=request.Town,
            CompanyName=request.CompanyName,
            PhoneNumber=request.PhoneNumber,
            FaxNumber=request.FaxNumber,
            FullAddress=request.FullAddress,
            YearOfFoundation=request.YearOfFoundation,
            CustomerType=CustomerTypeEnum.FromValue(request.CustomerTypeEnumValue)
        };

        await customerRepository.AddAsync(customer,cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);

    }
}
