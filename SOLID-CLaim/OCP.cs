namespace SOLID_CLaim
{

    //**Open-Closed Principle(OCP)**

    //This interface ensures that all discount types implement the CalculateDiscount() method.

    // If a new company, say Amazon, needs to be added, you can simply create a new class AmazonCalculateDiscount that implements IDiscount without changing any existing code.
    public interface IDiscount
    {
        decimal CalculateDiscount();
    }

    //Each class provides its own discount logic by implementing the IDiscount interface.
    public class MicrosoftCalculateDiscount : IDiscount
    {
        public decimal CalculateDiscount()
        {
            return 5m;
        }
    }
    public class DellCalculateDiscount : IDiscount
    {
        public decimal CalculateDiscount()
        {
            return 0m;
        }
    }
    public class GoogleCalculateDiscount : IDiscount
    {
        public decimal CalculateDiscount()
        {
            return 10m;
        }
    }
}
