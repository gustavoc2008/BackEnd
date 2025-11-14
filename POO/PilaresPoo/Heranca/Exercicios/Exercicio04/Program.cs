using Exercicio04;

Console.Clear();
Aluno aluno = new Aluno();
Pessoa AlunoGeneric = new Pessoa();
aluno.nome = "Gustavo";
aluno.idade = 17;
aluno.curso = "Desenvolvimento de Sistemas";
aluno.ExibirInfo();

Console.Clear();
Professor professor = new Professor();
Pessoa ProfessorGeneric = new Pessoa();
professor.nome = "Eduardo";
professor.idade = 43;
professor.disciplina = "Area de TI";
professor.ExibirInfo();

