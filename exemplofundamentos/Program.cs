using exemplofundamentos.Models;

    string apresentacao = "Olá, seja bem-vindo!";
    int quantidade = 1;
    double altura = 1.80;
    decimal preco = 1.80M;
    bool condicao = true;

    Console.WriteLine(apresentacao);
    Console.WriteLine("Valor da variável quantidade: " + quantidade);
    Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
    Console.WriteLine("Valor da variável preço: " + preco);
    Console.WriteLine("Valor da variável condição: " + condicao);

//Pessoa p = new Pessoa();

//p.Nome = "Rafaella";
//p.Idade = 26;
//p.Apresentar();