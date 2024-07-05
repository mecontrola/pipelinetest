using FluentValidation;
using MeControla.Core.Data.Dtos;
using MeControla.Core.Data.Entities;
using MeControla.Core.Tests.Exceptions;
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace MeControla.StockAnalytics.Core.Tools
{
    [StackTraceHidden]
    public static class ThrowValidatorTools
    {
        [DoesNotReturn]
        public static void ThrowIfInvalid<TEntity, TInputDto>(this IValidator<TInputDto> validator, TInputDto input)
            where TEntity : class, IModificationDateTimeEntity
            where TInputDto : class, IInputDto
        {
            ArgumentNullException.ThrowIfNull(validator);

            var result = validator.Validate(input);
            if (result.IsValid)
                return;

            throw new FormValidationException(typeof(TEntity), result);
        }
    }
}