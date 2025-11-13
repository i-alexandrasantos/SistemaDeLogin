using System;

namespace SistemaDeLogin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            CriarConta criarConta = new CriarConta();

            while (continuar == true)
            {
                Console.WriteLine("::::: Bem vindo(a) ao Sistema :::::");
                Console.WriteLine("Selecione abaixo uma opção para continuar...");
                Console.WriteLine(" ");

                Console.WriteLine("1 - Logar no sistema");
                Console.WriteLine("2 - Criar conta");
                Console.WriteLine("3 - Sair do sistema");
                Console.WriteLine(" ");

                int menu = Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        criarConta.Logar();
                        break;
                    case 2:
                        criarConta.NovaConta(menu);
                        break;
                    case 3:
                        Console.WriteLine("Encerrando...");
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção Inválida, tente novamente.");
                        Console.WriteLine("");
                        break;
                }
            }
        }
    }
}
