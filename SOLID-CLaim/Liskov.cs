namespace SOLID_CLaim
{
    //**Liskov Substitution Principle(LSP)**

    //Ensures that derived classes(DellCopayment, MicrosoftCopayment) can replace base classes without breaking the expected behavior
    public class Copayment
    {
        // AddCopayment takes claim amount and adds a base fee.
        public virtual decimal AddCopayment(decimal claimAmount)
        {
            return claimAmount + 100;// Base copayment is $100.
        }
    }

    public class MicrosoftCopayment : Copayment
    {
        public override decimal AddCopayment(decimal claimAmount)
        {
            if (claimAmount > 10000)
            {
                // No additional copayment for large claims.
                return claimAmount;
            }
            
                return base.AddCopayment(claimAmount) + 100;// Follows base logic otherwise.

        }
    }

    public class DellCopayment : Copayment
    {
        public override decimal AddCopayment(decimal claimAmount)
        {

            // Adds an additional $50 on top of the base copayment.
            return base.AddCopayment(claimAmount) + 50;


        }
    }
}
