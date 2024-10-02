using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        private string _nome;
        public string Nome 
        {
            get
            {
                return _nome.ToUpper(); //toupper deixa tudo maiúsculo
            }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome deve ser preenchido.");
                }

                _nome = value;
            }
        }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome} Idade: {Idade}");
        }
    }
}