using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Interfaces
{
    public interface ICalculadora
    {
        int Somar(int num1, int num2);
        int Subtrair(int num1, int num2);
        int Multiplicar(int num1, int num2); //métodos sem corpo são obrigatoriamente implementados
        int Dividir(int num1, int num2){ //métodos com corpo não precisam ser implementados
            return num1 / num2;
        }
    }
}