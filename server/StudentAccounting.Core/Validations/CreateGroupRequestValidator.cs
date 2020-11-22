using FluentValidation;
using StudentAccounting.Shared.DTOs.Group;

namespace StudentAccounting.Core.Validations
{
    public class CreateGroupRequestValidator : AbstractValidator<CreateGroupRequest>
    {
        public CreateGroupRequestValidator()
        {
            RuleFor(g => g.Name)
                .NotEmpty()
                .MaximumLength(25);
        }
    }
}
