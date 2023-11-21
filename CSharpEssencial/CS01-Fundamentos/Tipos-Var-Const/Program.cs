// TIPOS: INFERÊNCIA DE TIPOS

// var: um tipo implícito

var nome = "Evan"; // exemplo 1
var idade = 23;
var altura = 1.77;
Console.WriteLine($"{nome} tem {idade} anos e mede {altura} de altura.");

var p = new Pessoa("Yumi", 22, 1.75); // exemplo 2
Console.WriteLine($"{p.Nome} tem {p.Idade} anos e mede {p.Altura} de altura.");


// const: uma variável imutável

const int a = 9; // uma declaração
const int b = 2, c = 3; // múltiplas declarações
const double d = (float)a / b * c; // armazena resultados de operações

Console.WriteLine($"{a} / {b} * {c} = {d}");


Console.ReadKey();



class Pessoa
{
    public Pessoa(string? nome, int idade, double altura)
    {
        Nome = nome;
        Idade = idade;
        Altura = altura;
    }

    public string? Nome { get; set; }
    public int Idade { get; set; }
    public double Altura { get; set; }
}
