using System;
using funcoes_conta.Class;
using System.Threading;

namespace Console_bank;

class Program
{

    public static void Main()
    {
        Conta contaPrincipal = new Conta("Paulo Vitor", 500.00);
        Conta contaSegundaria = new Conta("Raissa Ribeiro", 100.00);

        inicio:
        Console.Clear();
        Console.WriteLine($"***Bem vindo ao inter de texto {contaPrincipal.Titular}***\n");
        Console.WriteLine($"O saldo atual de sua conta é: R$ {contaPrincipal.Saldo}\n");
        Console.WriteLine("Seleciona a função que deseja utilizar:\n");


        Console.WriteLine("1 - Listar Contas \n\n2 - Deposito\n\n3 - Transferencia\n");

        string funcao = Console.ReadLine();

        switch (funcao){
            case "1":
                Console.Clear();
                Console.WriteLine(contaPrincipal);
                Console.WriteLine(contaSegundaria);
                Console.WriteLine("Pressione enter para voltar;");
                Console.ReadLine();
                goto inicio;
                break;

                case "2":
                Console.Clear();
                Console.WriteLine("Digite o valor do deposito:\n");
                Console.Write("R$ ");
                double valor_deposito = double.Parse(Console.ReadLine());
                contaPrincipal.deposito(valor_deposito);
                goto inicio;
                break;
                
                case "3":
                Console.Clear();
                Console.WriteLine($"Saldo disponivel para transferencia: R${contaPrincipal.Saldo}\n");
                Console.WriteLine("Digite o valor da transferencia:\n");
                Console.Write("R$ ");
                double valor_transferencia = double.Parse(Console.ReadLine());
                bool saldo_insuficiente = contaPrincipal.transferencia(valor_transferencia);
                if (saldo_insuficiente)
                {
                    Console.WriteLine("\nSaldo insuficiente\n");
                    Console.ReadLine();
                    goto inicio;
                }
                else
                {
                    contaSegundaria.deposito_transferencia(valor_transferencia);
                    goto inicio;
                }
                break;
                default:
                Console.Clear();
                Console.WriteLine("\n\n\nSelecione uma opção valida animal\n\n\n");
                Thread.Sleep(2000);
                goto inicio;

        }
    }
}
