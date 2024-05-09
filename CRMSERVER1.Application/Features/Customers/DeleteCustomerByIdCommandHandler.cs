using CRMSERVER1.Domain.Entities;
using CRMSERVER1.Domain.Repositories;
using GenericRepository;
using MediatR;

namespace CRMSERVER1.Application.Features.Customers;

internal sealed class DeleteCustomerByIdCommandHandler(ICustomerRepository customerRepository,IUnitOfWork unitOfWork) : IRequestHandler<DeleteCustomerByIdCommand>
{
    public async Task Handle(DeleteCustomerByIdCommand request, CancellationToken cancellationToken)
    {
        Customer customer = await customerRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);
        if(customer is null)
        {
            throw new ArgumentException("Müşteri bulunamadı");
        }

        customerRepository.Delete(customer);
        await unitOfWork.SaveChangesAsync(cancellationToken);
    }
}
