using CRMSERVER1.Domain.Abstractions;
using CRMSERVER1.Domain.Enums;

namespace CRMSERVER1.Domain.Entities;
public class Customer:Entity
{
    public string CompanyName { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string Town { get; set; } = string.Empty;
    public string Street { get; set; } = string.Empty;
    public string BuildName { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string FaxNumber { get; set; } = string.Empty;
    public string FullAddress { get; set; } = string.Empty;
    public DateOnly YearOfFoundation { get; set; } 
    public CustomerTypeEnum CustomerType { get; set; } = CustomerTypeEnum.Kamu;

}
