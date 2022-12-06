using Intermediario.Models;
using System.Globalization;

string datastring = "2022-12-12 18:00";
bool sucesso = DateTime.TryParseExact(datastring, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

if (sucesso)
{
}
else
{
    Console.WriteLine($"Conversão falhou! {data} não é uma data válida.");
}


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

