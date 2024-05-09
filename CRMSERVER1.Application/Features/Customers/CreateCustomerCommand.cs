using CRMSERVER1.Domain.Enums;
using MediatR;

namespace CRMSERVER1.Application.Features.Customers;
public sealed record CreateCustomerCommand(
    string CompanyName,
    string Country,
    string City,
    string Town,
    string Street,
    string PhoneNumber,
    string FaxNumber,
    string FullAddress,
    string BuildName,
    DateOnly YearOfFoundation,
    int CustomerTypeEnumValue):IRequest;
