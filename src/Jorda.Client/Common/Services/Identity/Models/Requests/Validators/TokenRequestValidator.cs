using FluentValidation;

namespace Jorda.Client.Common.Services.Identity.Models.Requests.Validators
{
    public class TokenRequestValidator : AbstractValidator<TokenRequest>
    {
        public TokenRequestValidator()
        {
            RuleFor(request => request.Email).NotEmpty()
                .WithMessage("Srednio");

            RuleFor(request => request.Password).NotEmpty()
                .WithMessage("zle");
        }
    }
}
