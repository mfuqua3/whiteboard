namespace EntityConfigurations.Entities;

public class MerchantLocation
{
    public Guid Id { get; set; }
    
    public List<LocationHoliday> LocationHolidays { get; set; }
}