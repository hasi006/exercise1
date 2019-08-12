using AccessModifiersCL;

namespace AccessModifiers
{
    public class GoldCustomer:Customer
    {

        public int GiveOffer()
        {
            return CalculateRating(true);
        }
    }

    public class GoldCustomerCL : CustomerCL
    {

        public int GiveOffer()
        {
            //return CalculateRating(true);//this method shoudnt be accessible in here
            return 0;
        }
    }
}
