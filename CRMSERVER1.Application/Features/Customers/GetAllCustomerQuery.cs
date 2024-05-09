using CRMSERVER1.Domain.Entities;
using MediatR;

namespace CRMSERVER1.Application.Features.Customers;
public sealed record GetAllCustomerQuery(
   ) : IRequest<List<Customer>>;
