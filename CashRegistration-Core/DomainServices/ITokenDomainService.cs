using CashRegistration_Core.Entities;

namespace CashRegistration_Core.DomainServices
{
    public interface ITokenDomainService
    {
        long Generate(long cardNumber, int cvv);
        bool Validate(CustomerCard customerCard, long token, int cvv);
    }
}