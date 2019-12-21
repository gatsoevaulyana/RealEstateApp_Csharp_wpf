namespace RealEstate.Interfaces
{
    interface RealEstateInterface
    {
        string[] GetInfoAsArray();
        string getInfoAsString();
        string getRegion();
        double getArea();
        decimal getPrice();
    }
}
