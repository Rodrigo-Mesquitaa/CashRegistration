using CashRegistration.Application.InputModels;
using CashRegistration.Application.ViewsModels;
using CashRegistration_Core.DomainServices;
using CashRegistration_Core.Entities;
using CashRegistration_Core.Repositories;
using System.Threading.Tasks;

namespace CashRegistration.Application.Services
{
    public class CustomerCardService : ICustomerCardService
{
    private readonly ICustomerCardRepository _customerCardRepository;
    private readonly ITokenDomainService _tokenDomainService;
    public CustomerCardService(ICustomerCardRepository customerCardRepository, ITokenDomainService tokenDomainService)
    {
        _customerCardRepository = customerCardRepository;
        _tokenDomainService = tokenDomainService;
    }

    public async Task<CustomerCardViewModel> Save(CustomerCardInputModel customerCardInputModel)
    {
        var customerCard = new CustomerCard(customerCardInputModel.CustomerId, customerCardInputModel.CardNumber);

        var token = _tokenDomainService.Generate(customerCardInputModel.CardNumber, customerCardInputModel.CVV);

        await _customerCardRepository.Add(customerCard);

        return new CustomerCardViewModel(customerCard.RegistrationDate, token, customerCard.Id);
    }

    public async Task<ValidateTokenViewModel> Validate(ValidateTokenInputModel validateTokenInputModel)
    {
        var customerCard = await _customerCardRepository.GetById(validateTokenInputModel.CardId, validateTokenInputModel.CustomerId);

        if (customerCard == null)
            return new ValidateTokenViewModel(false);

        var isValid = _tokenDomainService.Validate(customerCard, validateTokenInputModel.Token, validateTokenInputModel.CVV);

        return new ValidateTokenViewModel(isValid);
    }
}
}