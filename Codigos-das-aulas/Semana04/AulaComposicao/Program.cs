using AulaComposicao.Classes;


//Endereco endereco = new Endereco()
//{
//    Logradouro = "Sua rua",
//    Numero = "123",
//    Estado = "Seu estado",
//    Cidade = "Sua cidade",
//    Pais = "Brasil",
//    CEP = "99000000"
//};

//Cliente paulo = new Cliente("Paulo", DateTime.Parse("1999-01-25"), endereco);


Cliente bruno = new Cliente();

bruno.Nome = "Bruno Costa";
bruno.Nascimento = DateTime.Parse("1999-01-25");

Console.WriteLine(bruno.Nome);

Aluno aluno = new Aluno();

aluno.Nome = "Paulo";

aluno.Curso = "Fullstack";
