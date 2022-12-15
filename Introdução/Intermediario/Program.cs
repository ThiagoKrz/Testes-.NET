using Intermediario.Models;
using System.Globalization;

int numero = 21;
bool ehPar = false;

// IF TERNARIO
ehPar = numero % 2 == 0;

Console.WriteLine($"O número {numero} é " + (ehPar ?"par":"impar"));

// IF NÃO TERNARIO
// if (numero % 2 == 0)
// {
//     Console.WriteLine($"O número {numero} é par");
// }
// else
// {
//     Console.WriteLine($"O número {numero} é impar");
// }












// Pessoa p1 = new Pessoa("Bruno", "Valentim");

// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome} {sobrenome}");

// LeituraArquivo arquivo = new LeituraArquivo();

// var (Sucesso, Linhas, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if (Sucesso)
// {
//     // Console.WriteLine($"Quantidade linhas do arquivo: {QuantidadeLinhas}");
//     foreach(string linhas in Linhas)
//     {
//         Console.WriteLine(linhas);
//     }
// }
// else
// {
//     Console.WriteLine("Não foi possível ler o arquivo.");
// }


// (int ID, string Nome, string Sobrenome) tupla = (1, "Bruno", "Valentim");
// ValueTuple<int, string, string> outraTupla = (2, "Caio", "Freire");
// var outraTuplaCreate = Tuple.Create(3, "Cleverson", "Souza");

// Console.WriteLine($"ID: {tupla.Item1}");
// Console.WriteLine($"Nome: {tupla.Item2}");
// Console.WriteLine($"Sobrenome: {tupla.Item3}");

// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("RO", "Rondônia");
// estados.Add("SP", "São Paulo");
// estados.Add("RJ", "Rio de Janeiro");

// foreach(KeyValuePair<string, string> item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}.");
// }

//     Console.WriteLine("----------------");

// estados.Remove("SP");
// estados["SP"] = "São Paulo - Valor alterado";

// foreach(KeyValuePair<string, string> item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}.");
// }

// string chave = "BH";
// Console.WriteLine($"Verficiando o elemento {chave}");

// if (estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor existente: {chave}");
// }
// else
// {
//     Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
// }

//     Console.WriteLine(estados["SP"]);
// Stack<int> pilha = new Stack<int>();

// pilha.Push(1);
// pilha.Push(3);
// pilha.Push(6);
// pilha.Push(9);
// pilha.Push(12);

// foreach(Int16 item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

// pilha.Push(20);

// foreach(Int16 item in pilha)
// {
//     Console.WriteLine(item);
// }

// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(3);
// fila.Enqueue(4);
// fila.Enqueue(5);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
// fila.Enqueue(10);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }

// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu uma erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Chegou até aqui.");
// }

// string datastring = "2022-12-12 18:00";
// bool sucesso = DateTime.TryParseExact(datastring, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

// if (sucesso)
// {
// }
// else
// {
//     Console.WriteLine($"Conversão falhou! {data} não é uma data válida.");
// }

// DateTime data = DateTime.Now;
// DateTime dataparse = DateTime.Parse("17/04/2022 18:00");
// string datastring = "2022-04-16 18:00";
// DateTime datastr = DateTime.Parse(datastring);

// Console.WriteLine(data.ToString("dd/MM/yyyy"));
// Console.WriteLine(data.ToString("yyyy-MM-dd mm:HH"));
// Console.WriteLine(data.ToShortDateString());
// Console.WriteLine(dataparse);

// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 2582.40M;

// Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
// Console.WriteLine($"{valorMonetario:C}");
// Console.WriteLine(valorMonetario.ToString("C8"));

// double porcentagem = .3421;
// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 1234567;
// Console.WriteLine(numero.ToString("##-###-##"));

// string numero1 = "10";
// string numero2 = "20";

// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);

// Pessoa p1 = new Pessoa(nome: "Alexandre", sobrenome: "Esteves");
// Pessoa p2 = new Pessoa(nome: "Caio", sobrenome: "Freire");
// Pessoa p3 = new Pessoa(nome: "Bruno", sobrenome: "Valentim");
// Pessoa p4 = new Pessoa(nome: "Cleverson", sobrenome: "Souza");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.AdicionarAluno(p3);
// cursoDeIngles.AdicionarAluno(p4);
// cursoDeIngles.ListarAlunos();

