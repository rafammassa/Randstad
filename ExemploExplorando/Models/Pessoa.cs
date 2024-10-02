using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        private string _nome;
        private int _idade;
        public string Nome 
        {
            get => _nome.ToUpper(); 
            //toupper deixa tudo maiúsculo
            //=> substitui o return

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome deve ser preenchido.");
                }

                _nome = value;
            }
        }

        public string Sobrenome
        { 
            get; 
            set; 
        }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        public int Idade 
        { 
            get => _idade;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade deve ser maior que 0.");
                }
                
                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto} Idade: {Idade}");
        }
    }
}