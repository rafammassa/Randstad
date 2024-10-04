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

Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("es-ES")));

double porcentagem = .3421;
Console.WriteLine(porcentagem.ToString("P"));

int numero = 123456;
Console.WriteLine(numero.ToString("##-##-##"));

DateTime data = DateTime.Now;
Console.WriteLine(data);
Console.WriteLine(data.ToString("dd/MM/yy HH:mm"));
Console.WriteLine(data.ToShortDateString());

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

DateTime data2 = DateTime.Parse("17/04/2022 18:00");
Console.WriteLine(data2);

try
{
    string[] linhas = File.ReadAllLines("Arquivos/arquivo-Leitura.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
} catch (Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
}