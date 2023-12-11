namespace EntityConfigurations.Entities;

public class LocationHoliday
{
    public Guid Id { get; set; }
    public Guid LocationId { get; set; }
    public Guid HolidayId { get; set; }
    public DateOnly CustomDate { get; set; }
    
    public Holiday Holiday { get; set; }
    public MerchantLocation Location { get; set; }
}