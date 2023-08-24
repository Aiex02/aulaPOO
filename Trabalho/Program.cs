
using Trabalho;

Aluguel aluguel = new Aluguel();

Console.WriteLine("Quantidade de dias que ficara com o caro:");
double dias = double.Parse(Console.ReadLine());

Console.WriteLine("Quilometragem inicial:");
double kmInicial = double.Parse(Console.ReadLine());

Console.WriteLine("Quilometragem final:");
double kmFinal = double.Parse(Console.ReadLine());

double resultado = aluguel.AluguelCarro(dias, kmInicial, kmFinal);

Console.WriteLine(resultado);

Console.WriteLine("Iniciando o jogo de adivinhação!");
AdivinhaNum.JogarJogo(); 
