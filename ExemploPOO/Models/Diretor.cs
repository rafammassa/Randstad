using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Diretor : Professor //Para de funcionar após selar a classe Professor
    {
        public Diretor(string nome) : base(nome){

        }
    }
}