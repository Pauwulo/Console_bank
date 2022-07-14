using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcoes_conta.Class
{
    public class Conta
    {
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public Conta(string titular, double saldo)
        {
            Titular = titular;  
            Saldo = saldo;
        }

        public void deposito(double valor_deposito)
        {
            this.Saldo += valor_deposito;
            Console.WriteLine($"\nDeposito efetivado com sucesso!\n");
            Console.WriteLine($"Seu salto atual é: R$ {this.Saldo}\n");
            Console.WriteLine("Pressione Enter para voltar\n");
            Console.ReadLine();
        }

        public void deposito_transferencia(double valor_deposito)
        {
            this.Saldo += valor_deposito;
            Console.WriteLine($"\nTransferencia efetivada com sucesso!\n");
            Console.WriteLine("Pressione Enter para voltar\n");
            Console.ReadLine();
        }

        public bool transferencia(double valor_transferencia)
        {
            // Verificar se existe saldo na conta
            if (this.Saldo - valor_transferencia < 0)
            {
                return true;
            }
            else
            {
                this.Saldo -= valor_transferencia;
                return false;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Titular: {this.Titular}");
            sb.AppendLine($"Saldo: R${this.Saldo.ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();

        }

    }
}
