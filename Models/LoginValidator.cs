using FluentValidation;

namespace AddressBook.Models
{
	public class LoginValidator : AbstractValidator<UsuarioModel>
	{
		public LoginValidator()
		{
			RuleFor(x => x.Nome)
				.NotEmpty().WithMessage("Informe o nome completo.")
				.Length(3).WithMessage("O nome deve ter minímo de 3 caracteres.");

			RuleFor(c => c.Login)
				.NotEmpty().WithMessage("Informe o nome de usuário desejado.")
				.Length(4, 100).WithMessage("O nome de usuario deve ter minímo de 3 caracteres e máximo de 100 caracteres.");

			RuleFor(c => c.Senha)
			.NotEmpty().WithMessage("Informe a senha desejada.")
			.Length(6, 32).WithMessage("A senha deve ter minímo de 6 caracteres e máximo de 32 caracteres.");


		}
	}
}
