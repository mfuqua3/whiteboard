namespace EntityConfigurations.Entities;

public class Holiday
{
    public Guid Id { get; set; }
    public string HolidayName { get; set; }
    public DateOnly HolidayDate { get; set; }
    
    public List<LocationHoliday> LocationHolidays { get; set; }
}