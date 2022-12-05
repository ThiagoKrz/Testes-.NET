using Intermediario.Models;

Pessoa p1 = new Pessoa(nome: "Alexandre", sobrenome: "Esteves");
Pessoa p2 = new Pessoa(nome: "Caio", sobrenome: "Freire");
Pessoa p3 = new Pessoa(nome: "Bruno", sobrenome: "Valentim");
Pessoa p4 = new Pessoa(nome: "Cleverson", sobrenome: "Souza");



Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.AdicionarAluno(p3);
cursoDeIngles.AdicionarAluno(p4);
cursoDeIngles.ListarAlunos();

