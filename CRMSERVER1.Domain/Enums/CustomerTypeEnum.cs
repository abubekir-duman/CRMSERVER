using Ardalis.SmartEnum;

namespace CRMSERVER1.Domain.Enums;
public sealed class CustomerTypeEnum : SmartEnum<CustomerTypeEnum>
{
    public static readonly CustomerTypeEnum Kamu = new CustomerTypeEnum("Kamu", 1);
    public static readonly CustomerTypeEnum Limited = new CustomerTypeEnum("Limited Şirketi", 2);
    public static readonly CustomerTypeEnum Anonim = new CustomerTypeEnum("Anonim Şirketi", 3);
    public static readonly CustomerTypeEnum Bireysel = new CustomerTypeEnum("Bireysel", 4);

    public CustomerTypeEnum(string name, int value) : base(name, value)
    {
    }
}
