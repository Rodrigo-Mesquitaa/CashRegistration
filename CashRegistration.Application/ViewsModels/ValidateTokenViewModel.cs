﻿namespace CashRegistration.Application.ViewsModels
{
    public class ValidateTokenViewModel
{
    public ValidateTokenViewModel(bool validated)
    {
        Validated = validated;
    }

    public bool Validated { get; private set; }
}
}