using CashRegistration.Application.InputModels;
using CashRegistration.Application.ViewsModels;
using System.Threading.Tasks;

namespace CashRegistration.Application.Services
{
    public interface ICustomerCardService
{
    Task<CustomerCardViewModel> Save(CustomerCardInputModel customerCardInputModel);
    Task<ValidateTokenViewModel> Validate(ValidateTokenInputModel validateTokenViewModel);
}
}