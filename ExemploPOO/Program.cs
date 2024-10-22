using ExemploPOO.Models;

//Pessoa p1 = new Pessoa();
//p1.Nome = "Rafaella";
//p1.Idade = 26;

//p1.Apresentar();

//ContaCorrente c1 = new ContaCorrente(1589, 1000);

//c1.ExibirSaldo();
//c1.Sacar(500);
//c1.ExibirSaldo();

Aluno a1 = new Aluno();
a1.Nome = "Eduardo";
a1.Idade = 24;
a1.Nota = 10;
a1.Apresentar();

Professor p1 = new Professor();
p1.Nome = "Paloma";
p1.Idade = 30;
p1.Salario = 1000;
p1.Apresentar();

Corrente c = new Corrente();
c.Creditar(500);
c.ExibirSaldo();
