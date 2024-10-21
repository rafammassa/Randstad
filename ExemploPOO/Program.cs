using ExemploPOO.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "Rafaella";
p1.Idade = 26;

p1.Apresentar();

ContaCorrente c1 = new ContaCorrente(1589, 1000);

c1.ExibirSaldo();
c1.Sacar(500);
c1.ExibirSaldo();