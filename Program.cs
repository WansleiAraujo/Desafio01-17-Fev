Console.WriteLine("Digite um texto: ");
string texto = Console.ReadLine();

int qPalavras = texto.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
int qCaracteres = texto.Length;

Console.WriteLine(qCaracteres + " caracteres, " + qPalavras + " palavras");