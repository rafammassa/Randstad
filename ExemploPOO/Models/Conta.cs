using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public abstract class Conta //abstract indica que a classe não pode ser instanciada, somente herdada
    {
        protected decimal saldo; //protected pode ser acessado pelas classes filhas

        public abstract void Creditar(decimal valor);

        public void ExibirSaldo(){
            Console.WriteLine("O seu saldo é R$" + saldo);
        }
    }
}