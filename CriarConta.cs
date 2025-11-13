
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
                Console.WriteLine("Insira o primeiro nome: ");
                Nome = Console.ReadLine();
                Console.WriteLine("--");

                Console.WriteLine($"Olá, {Nome}. Agora digite a data de nascimento:");
                DataNascimento = Console.ReadLine();
                Console.WriteLine("--");

                Console.WriteLine("Digite um nome de usuário para acessar o sistema:");
                NomeDoUsuario = Console.ReadLine();
                Console.WriteLine("--");

                Console.WriteLine("Digite o e-mail e depois a senha:");
                Email = Console.ReadLine();
                Senha = Console.ReadLine();
                Console.WriteLine("--");

                Console.WriteLine("Por favor, digite a senha novamente:");
                ConfirmacaoSenha = Console.ReadLine();

                while (!Senha.Equals(ConfirmacaoSenha))
                {
                    Console.WriteLine("A senha está incorreta, por favor, tente novamente");
                    ConfirmacaoSenha = Console.ReadLine();
                    Console.WriteLine("--");
                }

                Console.WriteLine("Confirmado, as senhas são iguais e sua conta foi criada!");
                Console.WriteLine("--");

                Console.WriteLine("Agora anote as informações para logar no sistema: ");
                Console.WriteLine($"Usuário: {NomeDoUsuario}. E-mail: {Email}");
   
                return true;

            }
            else
            {
                return false;

            }
        }

        public void Logar()
        {

            if(Email != null)
            {
                Console.WriteLine("Insira o e-mail cadastrado");
                string validaEmail = Console.ReadLine();

                if (validaEmail == Email)
                {
                    bool operadorSenha = true;

                    while(operadorSenha = true)
                    {
                        Console.WriteLine("Agora digite a senha cadastrada:");

                        string validaSenha = Console.ReadLine();

                        if (validaSenha == Senha)
                        {
                            Console.WriteLine("Senha correta, logando no sistema...");
                            Console.WriteLine($"Bem vindo(a) {Nome}, você está logado(a).");
                            operadorSenha = false;
                        }
                        else
                        {
                            Console.WriteLine("Senha incorreta, por favor tente novamente.");
                        }

                    }

                    Console.WriteLine("Reiniciando...");
                }
                else
                {
                    Console.WriteLine("E-mail não encontrado na base de cadastro.");
                }

            }
            else
            {
                Console.WriteLine("Para logar no sistema, você precisa criar uma conta.");
            }

            Console.WriteLine("");
        }
    }
}
