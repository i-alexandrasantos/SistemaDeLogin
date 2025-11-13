
using System;

namespace SistemaDeLogin
{
    public class CriarConta
    {
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public string NomeDoUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string ConfirmacaoSenha { get; set; }

        // Método Criação da Conta
        public Boolean NovaConta(int valor)
        {
            if (valor == 2)
            {
                Console.WriteLine("Insira as informações abaixo para criar sua nova conta: ");
                Console.WriteLine("Insira o nome completo: ");
                Nome = Console.ReadLine();

                Console.WriteLine($"Olá, {Nome}. Agora digite a data de nascimento:");
                DataNascimento = Console.ReadLine();

                Console.WriteLine("Digite um nome de usuário para acessar o sistema:");
                NomeDoUsuario = Console.ReadLine();

                Console.WriteLine("Digite o e-mail e depois a senha:");
                Email = Console.ReadLine();
                Senha = Console.ReadLine();

                Console.WriteLine("Por favor, digite a senha novamente:");
                ConfirmacaoSenha = Console.ReadLine();


                Console.WriteLine("Conta criada com sucesso, por favor, anote as informações para logar no sistema: ");
                Console.WriteLine($"E-mail: {Email}. Senha: {Senha}");

                return true;
            }
            else
            {
                return false;
            }
        }

            
    }
}
