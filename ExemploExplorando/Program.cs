using ExemploExplorando.Models;
using System.Globalization;

Pessoa p1 = new Pessoa();
p1.Nome = "Rafaella";
p1.Sobrenome = "Massa";
p1.Idade = 26;
p1.Apresentar();

Pessoa p2 = new Pessoa();
p2.Nome = "Eduardo";
p2.Sobrenome = "Folco";
p2.Idade = 25;
p2.Apresentar();

Curso cursodeIngles = new Curso();
cursodeIngles.Nome = "Inglês";
cursodeIngles.Alunos = new List<Pessoa>();

cursodeIngles.AdicionarAluno(p1);
cursodeIngles.AdicionarAluno(p2);
cursodeIngles.ListarAlunos();

Pessoa p3 = new Pessoa("Paloma", "Machado");
p3.Idade = 25;
p3.Apresentar();

decimal valorMonetario = 1582.40M;
Console.WriteLine($"{valorMonetario:C}");
//:C converte para valor monetário configurado na máquina

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
Console.WriteLine($"{valorMonetario:C}");