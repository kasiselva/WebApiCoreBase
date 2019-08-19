using BaseWebApiCore.Models;
using FluentValidation;

namespace BaseWebApiCore.Validator
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator() {
		RuleFor(x => x.Id).NotNull();
		RuleFor(x => x.UserName).NotEmpty();
		RuleFor(x => x.Email).EmailAddress();
		RuleFor(x => x.Password).NotEmpty();
	}
    }
}