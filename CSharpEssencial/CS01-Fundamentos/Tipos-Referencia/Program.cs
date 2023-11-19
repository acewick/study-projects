// TIPOS DE DADOS POR REFERÊNCIA: STRING, OBJECT E DYNAMIC

// string: representa uma sequência de caracteres Unicode imutável
string frase = "Curso C# Essencial";
frase = "Criando uma nova frase"; // como strings são imutáveis, essa atribuição cria uma nova instância de string e descarta a anterior

Console.WriteLine(frase);

// object: é um tipo que pode armazenar qualquer valor ou referência
object nome1 = "Ana";
object idade1 = 25;
object altura1 = 1.60;
object genero1 = 'F';
object ativo1 = true;

Console.WriteLine($"{nome1}, {idade1} anos, {altura1} de altura, genero: ({genero1}), ativo: {ativo1}");

// dynamic: permite usar recursos avançados da linguagem, como a vinculação tardia, que resolve o tipo de uma variável em tempo de execução
dynamic nome2 = "Teo";
dynamic idade2 = 21;
dynamic altura2 = 1.85;
dynamic genero2 = 'M';
dynamic ativo2 = false;

Console.WriteLine($"{nome2}, {idade2} anos, {altura2} de altura, genero: ({genero2}), ativo: {ativo2}");

Console.ReadKey();
