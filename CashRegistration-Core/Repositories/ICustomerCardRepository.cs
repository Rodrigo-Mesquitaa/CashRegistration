using CashRegistration_Core.Entities;
using System.Threading.Tasks;

namespace CashRegistration_Core.Repositories
{
    public interface ICustomerCardRepository
    {
        Task<CustomerCard> GetById(int id, int customerId);
        Task Add(CustomerCard customerCard);
    }
}