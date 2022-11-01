using Testing.Models;

Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
    Console.WriteLine("Vogal");
    break;

    default:
    Console.WriteLine("Não é uma vogal");
    break;
}

// bool choveu = true;
// bool estaTarde = true;

// if(!choveu && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar.");
// }
// else
// {
//     Console.WriteLine("Vou pedalar outro dia.");
// }


// bool possuiPresencaMinima = true;
// int media = 7;

// if (possuiPresencaMinima && media>=7)
// {
//     Console.WriteLine("Passou");
// }
// else
// {
//     Console.WriteLine("Reprovou");
// }

// bool ehMaiorDeIdade = true;
// bool possuiAutorizacao = false;

// if (ehMaiorDeIdade || possuiAutorizacao)
// {
//     Console.WriteLine("Entrada liberada");
// }
// else
// {
//     Console.WriteLine("Entrada não liberada");
// }

// int quantidadeEmEstoque = 3;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

// if (quantidadeCompra==0)
// {
//     Console.WriteLine("Venda inválida.");
// }

// else if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada.");
// }
// else
// {
//     Console.WriteLine("Desculpe, não temos a quantidade de desejada em estoque.");
// }

// string a = "10-";
// int b = 25;
// int.TryParse(a, out b);

// int b = int.MaxValue;
// double a = Convert.ToInt32(b);
// Console.WriteLine(b);

// int a = 5;
// int b = 9;
// int inteiro = a+b;
// string segs = inteiro.ToString()+" vezes";
// Console.WriteLine(segs);


// int a = 10;
// int b = 20;
// int c = a+b;
// // c = c + 5;
// // c = c - 5;
// // c += 5;
// // c -= 5;
// c*= 5;

// Console.WriteLine(c);


// DateTime dataAtual= DateTime.Now.AddDays(5).AddHours(20);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));


// string salve = "Opa, salve salve, maninho!";
// int quantidade = 2;
// double altura = 1.8;
// decimal valor = 10.80M;
// bool condicao = true;
// Console.WriteLine(salve);
// Console.WriteLine("Valor da variável quantidade: "+quantidade);
// Console.WriteLine("Valor da variável altura: "+altura.ToString("0.00"));
// Console.WriteLine("Valor da variável valor: "+valor);
// Console.WriteLine("Valor da variável condição: "+condicao);


//Pessoa p1 = new Pessoa();
//p1.Nome="Bruno Valentim";
//p1.Idade=22;
//p1.Apresentar();

