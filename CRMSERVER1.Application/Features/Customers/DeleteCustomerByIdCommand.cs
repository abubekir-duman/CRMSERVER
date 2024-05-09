using MediatR;

namespace CRMSERVER1.Application.Features.Customers;
public sealed record DeleteCustomerByIdCommand(
    int Id) :IRequest;
