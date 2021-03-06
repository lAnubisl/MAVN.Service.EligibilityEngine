using System;
using FluentValidation;
using MAVN.Service.EligibilityEngine.Client.Models.ConversionRate;
using MAVN.Service.EligibilityEngine.Client.Models.ConversionRate.Requests;

namespace MAVN.Service.EligibilityEngine.Models.Validation.ConversionRate
{
    public class ConvertAmountByEarnRuleRequestValidator : BaseConvertAmountRequestValidator<ConvertAmountByEarnRuleRequest>
    {
        public ConvertAmountByEarnRuleRequestValidator() : base()
        {
            RuleFor(p => p.EarnRuleId)
                .Must(p => p != Guid.Empty)
                .WithMessage("Customer Id must be provided and must not be an empty GUID.");
        }
    }
}
