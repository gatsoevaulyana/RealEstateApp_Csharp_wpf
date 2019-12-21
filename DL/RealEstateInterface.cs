namespace RealEstate.Interfaces
{
   public interface RealEstateInterface
    {
        string[] GetInfoAsArray();
        string getInfoAsString();
        string getRegion();
        double getArea();
        decimal getPrice();
    }
}
