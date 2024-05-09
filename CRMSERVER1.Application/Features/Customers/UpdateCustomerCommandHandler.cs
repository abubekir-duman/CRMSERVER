using CRMSERVER1.Domain.Entities;
using CRMSERVER1.Domain.Enums;
using CRMSERVER1.Domain.Repositories;
using GenericRepository;
using MediatR;

namespace CRMSERVER1.Application.Features.Customers;

internal sealed class UpdateCustomerCommandHandler(ICustomerRepository customerRepository, IUnitOfWork unitOfWork) : IRequestHandler<UpdateCustomerCommand>
{
    public async Task Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
    {
        Customer customer = await customerRepository.GetByExpressionAsync(p=>p.Id==request.Id, cancellationToken);
        if(customer is null)
        {
            throw new ArgumentException("Müşteri bulunamadı");
        }

        customer.CompanyName = request.CompanyName;
        customer.Country = request.Country;
        customer.City = request.City;
        customer.Town = request.Town;
        customer.Street = request.Street;
        customer.BuildName = request.BuildName;
        customer.PhoneNumber = request.PhoneNumber;
        customer.FaxNumber = request.FaxNumber;
        customer.YearOfFoundation = request.YearOfFoundation;
        customer.FullAddress = request.FullAddress;
        customer.CustomerType = CustomerTypeEnum.FromValue(request.CustomerTypeEnumValue);

        customerRepository.Update(customer);
        await unitOfWork.SaveChangesAsync(cancellationToken);
    }
}

