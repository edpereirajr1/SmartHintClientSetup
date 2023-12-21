using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Results;

namespace Smart_Hint_Client_Base
{
    public class ClientValidator : AbstractValidator<AddClient>
    {
        //Add Methods, One for Each type of Client: CPF, CPF w Ins Estadual, CNPJ, CNPJ w Ins Estadual
        public ClientValidator(string clientType, bool inscricaoEstadual)
        {
            //Check first if client selected a person type, otherwise return
            RuleFor(client => client.PersonType).Cascade(CascadeMode.Stop)
                .NotNull().WithMessage("Selecione um tipo de Pessoa.");

            switch (clientType)
            {
                case "Fisica":
                    AllUsersCheck();
                    if (!inscricaoEstadual)
                    {
                        InscricaoEstadualCheck();
                    }
                    PfCheck();
                    break;
                case "Juridica":
                    AllUsersCheck();
                    InscricaoEstadualCheck();
                    CnpjCheck();
                    break;
            }

            void InscricaoEstadualCheck()
            {
                //Insc Estadual
                RuleFor(client => client.InscEstadual).Cascade(CascadeMode.Stop)
                    .Length(12).WithMessage("Inscricao Estadual Invalida. Utilize 12 Caracteres.")
                    .Must(IsValidInt).WithMessage("Utilize apenas numeros para a Inscricao Estadual");
            }

            void AllUsersCheck()
            {
                //Nome
                RuleFor(client => client.Name)
                    .Cascade(CascadeMode.Stop)
                    .Length(3, 150).WithMessage("Nome Invalido. Utilize de 3 a 150 Caracteres.")
                    .Must(IsValidString).WithMessage("Utilize apenas letras para o Nome.");

                //Email
                RuleFor(client => client.Email).Cascade(CascadeMode.Stop)
                    .EmailAddress().WithMessage("Endereco de E-mail Invalido.")
                    .Length(3, 150).WithMessage("Utilize de 3 a 150 Caracteres para o E-mail.");

                //Telefone
                RuleFor(client => client.Tel).Cascade(CascadeMode.Stop)
                    .Length(11).WithMessage("Telefone Invalido. Utilize 11 Numeros. Exemplo: 41987654321")
                    .Must(IsValidInt).WithMessage("Utilize apenas numeros para o Telefone");

                //Password
                RuleFor(client => client.Password).Cascade(CascadeMode.Stop)
                    .Length(8, 15).WithMessage("Senha Invalida. Utilize de 8 a 15 Caracteres")
                    .Equal(client => client.PasswordCheck).WithMessage("As senhas nao conferem");

                //Password Check
                RuleFor(client => client.PasswordCheck).Cascade(CascadeMode.Stop)
                    .Length(8, 15).WithMessage("Preencha a Confirmacao de Senha.")
                    .Equal(client => client.Password).WithMessage("As senhas nao conferem");
            }

            void PfCheck()
            {
                //CPF
                RuleFor(client => client.Cpf).Cascade(CascadeMode.Stop)
                    .Length(11).WithMessage("CPF Invalido. Utilize 11 Caracteres.")
                    .Must(IsValidInt).WithMessage("Utilize apenas numeros para o CPF");

                //Gender - Not null only
                RuleFor(client => client.Gender).Cascade(CascadeMode.Stop)
                    .MinimumLength(2).WithMessage("Selecione o Genero do Cliente"); //Make sure client selected a value

                //Birth Date - Check for bugs
                RuleFor(client => client.BirthDate).Cascade(CascadeMode.Stop)
                    .NotNull().WithMessage("Selecione a Data de Nascimento")
                    .LessThan(DateTime.Today).WithMessage("Selecione a Data de Nascimento");
            }

            void CnpjCheck()
            {
                //CNPJ
                RuleFor(client => client.Cnpj).Cascade(CascadeMode.Stop)
                    .Length(14).WithMessage("CNPJ Invalido. Utilize 14 Caracteres.")
                    .Must(IsValidInt).WithMessage("Utilize apenas numeros para o CNPJ");
            }
        }

        protected bool IsValidString(string x)
        {
            return x.All(Char.IsLetter);
        }


        protected bool IsValidInt(string x)
        {
            return x.All(Char.IsNumber);
        }

        protected bool IsValidPassword(string x, string y)
        {
            return (x == y);
        }
    }
}
