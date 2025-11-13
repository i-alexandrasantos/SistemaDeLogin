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
            //string nome = "";
            // string dataNascimento = "";
            int sexo = 0;
            string nomeUsuario = "";
            string email = "";
            string senha =  "";
            string confirmacaoSenha = "";

            // Inicio Criação da Conta

            Console.WriteLine("Insira as informações abaixo para criar sua nova conta: ");
            Console.WriteLine("Insira o nome completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine($"Olá, {nome}. Agora digite a data de nascimento");
            string dataNascimento = Console.ReadLine();

            // Fim Criação da Conta


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

            switch (menu)
            {
                case 1:
                    Console.WriteLine("Logado no sistema");
                    break;
                case 2:
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
