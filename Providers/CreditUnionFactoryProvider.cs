using AbstractFactories;
using CitiCreditUnion;
using NationalCreditUnion;

namespace Providers
{
    public class CreditUnionFactoryProvider
    {
        public static CreditUnionFactory GetCreditUnionFactory(string accountNo)
        {
            if (accountNo.Contains("CITI")) { return new CitiCreditUnionFactory(); }
            else if (accountNo.Contains("NATIONAL")) { return new NationalCreditUnionFactory(); }
            else
                return null;
        }
    }
}
