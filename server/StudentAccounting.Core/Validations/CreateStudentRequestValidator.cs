using System.Threading.Tasks;
using FluentValidation;
using StudentAccounting.Core.Models;
using StudentAccounting.Core.Services.Abstractions;
using StudentAccounting.Shared.DTOs.Student;

namespace StudentAccounting.Core.Validations
{
    public class CreateStudentRequestValidator : AbstractValidator<CreateStudentRequest>
    {
        public CreateStudentRequestValidator(IUniqueCheckService checkService)
        {
            RuleFor(s => s.Name)
                .NotEmpty()
                .MaximumLength(40);
            RuleFor(s => s.Surname)
                .NotEmpty()
                .MaximumLength(40);
            RuleFor(s => s.Middlename)
                .MaximumLength(60);
            RuleFor(s => s.Gender)
                .IsInEnum();
            RuleFor(s => s.UniqueStudentId)
                .MustAsync(async (value, token) => await checkService.CheckAsync(value))
                .Length(6, 16);
        }
    }
}
