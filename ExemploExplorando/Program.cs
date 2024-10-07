﻿using ExemploExplorando.Models;
using System.Collections;
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
} 

catch (FileNotFoundException ex)
{
    Console.WriteLine($"Ocorreu uma exceção genérica. O arquivo não foi encontrado. {ex.Message}");
}

catch (DirectoryNotFoundException ex)
{
    Console.WriteLine($"Ocorreu uma exceção genérica. O diretório não foi encontrado. {ex.Message}");
}

catch (Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
}
finally
{
    Console.WriteLine("Chegou até aqui!");
}

new ExemploExcecao().Metodo1();

Queue<int> fila = new Queue<int>();
fila.Enqueue(2); //Adicionando elemento a fila
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach (var item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
fila.Enqueue(10);

foreach (var item in fila)
{
    Console.WriteLine(item);
}

Stack<int> pilha = new Stack<int>();
pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(10);

foreach (var item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

pilha.Push(20);

foreach (var item in pilha)
{
    Console.WriteLine(item);
}

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");

foreach(KeyValuePair<string, string> item in estados)
//KeyValuePair<string, string> pode ser substituido por var
{
    Console.WriteLine($"Chave: {item.Key} Valor: {item.Value}");
}

estados.Remove("BA");
estados["SP"] = "São Paulo - valor alterado";

foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key} Valor: {item.Value}");
}

string chave = "BA";
Console.WriteLine($"Verificando o elemento {chave}");

if (estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor existente. {chave}");
} else{
    Console.WriteLine($"Valor não encontrado. É seguro adicionar a chave {chave}");
}

Console.WriteLine(estados["MG"]);

(int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Rafaella", "Massa", 1.60M);
Console.WriteLine($"Id: {tupla.Item1}");
Console.WriteLine($"Nome: {tupla.Item2}");
Console.WriteLine($"Sobrenome: {tupla.Item3}");
Console.WriteLine($"Altura: {tupla.Item4}");

LeituraArquivo arquivo = new LeituraArquivo();

var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

if(sucesso)
{
    Console.WriteLine($"Quantidade de linhas do arquivo: {quantidadeLinhas}");
    foreach (var linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
} else {
    Console.WriteLine("Não foi possível ler o arquivo.");
}