public class Apartment : Residence
{
    public int NumberOfBedrooms { get; set; }

    public Apartment(string residenceID, int numberOfBedrooms) : base(residenceID)
    {
        NumberOfBedrooms = number Of Bedrooms;
    }

    public override decimal CalculateMonthlyRent()
    {
        // Implement rent calculation based on number of bedrooms
        return NumberOfBedrooms * 500; // Assuming $500 per bedroom
    }
}
