using FluentValidation;
using MeControla.StockAnalytics.Data.Dtos.Inputs;

namespace MeControla.StockAnalytics.Core.Validators
{
#if DEBUG
    public
#else
    internal
#endif
    interface ICompanyInputDtoValidator : IValidator<CompanyInputDto>
    { }

#if DEBUG
    public
#else
    internal
#endif
    sealed class CompanyInputDtoValidator : AbstractValidator<CompanyInputDto>, ICompanyInputDtoValidator
    {
#if DEBUG
        public
#else
    internal
#endif
            const string FIELD_NAME_REQUIRED = "Name is required.";

#if DEBUG
        public
#else
    internal
#endif
            const string FIELD_NAME_BETWEENLENGTH = "Name should be between 5 and 100 chars";

        public CompanyInputDtoValidator()
        {
            RuleFor(x => x.Name).Cascade(CascadeMode.Stop)
                                .NotEmpty()
                                .WithMessage(FIELD_NAME_REQUIRED)
                                .Must(x => x.Length > 5 && x.Length < 100)
                                .WithMessage(FIELD_NAME_BETWEENLENGTH);
        }
    }
}