using MediatR;

namespace CRMSERVER1.Application.Features.Customers;
public sealed record UpdateCustomerCommand(
    int Id,
    string CompanyName,
    string Country,
    string City,
    string Town,
    string Street,
    string BuildName,
    string FullAddress,
    string PhoneNumber,
    string FaxNumber,
    DateOnly YearOfFoundation,
    int CustomerTypeEnumValue
    ):IRequest;

