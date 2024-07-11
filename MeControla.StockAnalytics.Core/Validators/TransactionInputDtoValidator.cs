using FluentValidation;
using MeControla.StockAnalytics.Data.Dtos.Inputs;

namespace MeControla.StockAnalytics.Core.Validators
{
#if DEBUG
    public
#else
    internal
#endif
    interface ITransactionInputDtoValidator : IValidator<TransactionInputDto>
    { }

#if DEBUG
    public
#else
    internal
#endif
    sealed class TransactionInputDtoValidator : AbstractValidator<TransactionInputDto>, ITransactionInputDtoValidator
    {

        public TransactionInputDtoValidator()
        {
        }
    }
}