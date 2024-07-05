using MeControla.StockAnalytics.Core.Builders;
using MeControla.StockAnalytics.Core.Services.Bases;
using MeControla.StockAnalytics.Core.Validators;
using MeControla.StockAnalytics.Data.Dtos.Inputs;
using MeControla.StockAnalytics.Data.Entities;
using MeControla.StockAnalytics.DataStorage.Repositories;

namespace MeControla.StockAnalytics.Core.Services
{
    public interface IRegisterSaveService : IBaseEntitySaveService<RegisterInputDto>
    { }

#if DEBUG
    public
#else
    internal
#endif
    sealed class RegisterSaveService(IRegisterRepository registerRepository,
                                     IRegisterInputDtoValidator registerInputDtoValidator)
        : BaseEntitySaveService<Register, RegisterInputDto>(registerRepository, registerInputDtoValidator), IRegisterSaveService
    {
        protected override void FillEntity(Register entity, RegisterInputDto input)
        {
            entity.Name = input.Name;
            entity.Website = input.Website;

            if (entity.Id == 0)
                entity.Active = true;
        }

        protected override Register BuildEntity()
            => RegisterBuilder.GetInstance().ToBuild();
    }
}