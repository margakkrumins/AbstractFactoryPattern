using Interfaces;

namespace AbstractFactories
{
    // Abstract Factory
    public abstract class CreditUnionFactory
    {
        public abstract ILoanAccount CreateLoanAccount();
        public abstract ISavingsAccount CreateSavingsAccount();
    }
}
