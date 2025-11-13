using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeLogin
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //criar minha conta

            


            //mudar senha
            string novaSenha = "";
            //// confirmação de senha

            //logar


            Console.WriteLine("::::: Bem vindo(a) ao Sistema :::::");
            Console.WriteLine("Selecione abaixo uma opção para continuar...");
            Console.WriteLine(" ");

            Console.WriteLine("1 - Logar no sistema");
            Console.WriteLine("2 - Criar conta");
            Console.WriteLine("3 - Mudar a senha");
            Console.WriteLine("4 - Sair do sistema");
            Console.WriteLine(" ");

            int menu = Convert.ToInt32(Console.ReadLine());

            CriarConta criarConta = new CriarConta();

           

            switch (menu)
            {
                case 1:
                    Console.WriteLine("Logado no sistema");
                    break;
                case 2:
                    criarConta.NovaConta(menu);

                    Console.WriteLine("Conta criada com sucesso!");
                    break;
                case 3:
                    Console.WriteLine("Senha alterada!");
                    break;
                case 4:
                    Console.WriteLine("Deslogado com sucesso!");
                    break;
            }

        }
    }
}
