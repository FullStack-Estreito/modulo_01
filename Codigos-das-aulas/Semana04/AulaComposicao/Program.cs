using AulaComposicao.Classes;


Endereco endereco = new Endereco()
{
    Logradouro = "Sua rua",
    Numero = "123",
    Estado = "Seu estado",
    Cidade = "Sua cidade",
    Pais = "Brasil",
    CEP = "99000000"
};

Cliente paulo = new Cliente("Paulo", DateTime.Parse("1999-01-25"), endereco);

Aluno bruno = new Aluno("Bruno", DateTime.Parse("1999-01-25"), endereco, "ADS", 1);

Funcionario antonio = new Funcionario("Desenvolvedor", 2000, "Antonio", DateTime.Parse("1999-01-25"), endereco);

paulo.Descrever();
bruno.Descrever();
antonio.Descrever();

//Cliente bruno = new Cliente();

//bruno.Nome = "Bruno Costa";
//bruno.Nascimento = DateTime.Parse("1999-01-25");

//Console.WriteLine(bruno.Nome);

//Aluno aluno = new Aluno();

//aluno.Nome = "Paulo";

//aluno.Curso = "Fullstack";

// Upcasting
//Pessoa pessoa = new Aluno("Bruno Costa", DateTime.Parse("1999-01-25"), endereco, "ADS", 1);

//Console.WriteLine(pessoa.Curso);

// Downcasting
//Aluno aluno = (Aluno)pessoa;
//tipo | nome da variável


// Temos duas formas de declarar uma variável:

// 1 º - usando var

//int numero = 10;
//tipo | nome da variavel


//using AulaComposicao.Classes;

//Cachorro cachorro = new Cachorro();

//cachorro.EmitirSom();

//Gato gato = new Gato();

//gato.EmitirSom();

