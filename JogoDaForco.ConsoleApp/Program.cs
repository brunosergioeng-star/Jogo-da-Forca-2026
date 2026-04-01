using System.Reflection.Metadata;
using System.Security.Cryptography;

string[] palavras = [
                "ABACATE",
                "ABACAXI",
                "ACEROLA",
                "ACAI",
                "ARACA",
                "ABACATE",
                "BACABA",
                "BACURI",
                "BANANA",
                "CAJA",
                "CAJU",
                "CARAMBOLA",
                "CUPUACU",
                "GRAVIOLA",
                "GOIABA",
                "JABUTICABA",
                "JENIPAPO",
                "MACA",
                "MANGABA",
                "MANGA",
                "MARACUJA",
                "MURICI",
                "PEQUI",
                "PITANGA",
                "PITAYA",
                "SAPOTI",
                "TANGERINA",
                "UMBU",
                "UVA",
                "UVAIA"
                ];

int indiceAleatorio = RandomNumberGenerator.GetInt32(palavras.Length);

string palavraAleatoria = palavras[indiceAleatorio];

char[] letrasCorretas = new char[palavraAleatoria.Length];

for (int contadorLetras = 0; contadorLetras < palavraAleatoria.Length; contadorLetras++)
{
    letrasCorretas[contadorLetras] = '_';
}

int contadorErros = 0;

bool jogadorAcertou = false;
bool jogadorPerdeu = false;

while (true)
{
    Console.Clear();

    Console.WriteLine("----------------------------");
    Console.WriteLine("Jogo da Forca");
    Console.WriteLine("----------------------------");
    Console.WriteLine("Erros cometidos: " + contadorErros + "Erros");
    Console.WriteLine("Chutes: ");

    for (int contadorLetras = 0; contadorLetras < palavraAleatoria.Length; contadorLetras++)
    {
        Console.Write(letrasCorretas[contadorLetras]);
    }

    if (contadorErros == 0)
    {
        Console.WriteLine(@" ___________        ");
        Console.WriteLine(@" |/        |        ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@"_|____              ");
    }

    else if (contadorErros == 1)
    {
        Console.WriteLine(@" ___________        ");
        Console.WriteLine(@" |/        |        ");
        Console.WriteLine(@" |         O        ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@"_|____              ");
    }

    else if (contadorErros == 2)
    {
        Console.WriteLine(@" ___________        ");
        Console.WriteLine(@" |/        |        ");
        Console.WriteLine(@" |         O        ");
        Console.WriteLine(@" |         |        ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@"_|____              ");
    }

    else if (contadorErros == 3)

    {
        Console.WriteLine(@" ___________        ");
        Console.WriteLine(@" |/        |        ");
        Console.WriteLine(@" |         O        ");
        Console.WriteLine(@" |        /|        ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@"_|____              ");
    }

    else if (contadorErros == 4)
    {
        Console.WriteLine(@" ___________        ");
        Console.WriteLine(@" |/        |        ");
        Console.WriteLine(@" |         O        ");
        Console.WriteLine(@" |        /|\       ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@"_|____              ");
    }

    else if (contadorErros == 5)
    {
        Console.WriteLine(@" ___________        ");
        Console.WriteLine(@" |/        |        ");
        Console.WriteLine(@" |         O        ");
        Console.WriteLine(@" |        /|\       ");
        Console.WriteLine(@" |       _/ \_      ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@"_|____              ");
    }

    else if (contadorErros == 6)
    {
        Console.WriteLine(@" ___________        ");
        Console.WriteLine(@" |/        |        ");
        Console.WriteLine(@" |         O        ");
        Console.WriteLine(@" |        /|\       ");
        Console.WriteLine(@" |       _/ \_      ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@"_|____              ");
    }

    Console.WriteLine("\n---------------------------------------");

    Console.WriteLine("\n----------------------------");
    Console.WriteLine("Digite uma letra: ");
    char chute = Convert.ToChar(Console.ReadLine());

    bool letraFoiEncontrada = false;

    for (int contadorPalavraAleatoria = 0; contadorPalavraAleatoria < palavraAleatoria.Length; contadorPalavraAleatoria++)
    {
        char letraAleatoriaAtual = palavraAleatoria[contadorPalavraAleatoria]; // 'A'

        if (chute == letraAleatoriaAtual)
        {
            letrasCorretas[contadorPalavraAleatoria] = chute;
            letraFoiEncontrada = true;
        }
    }

    if (!letraFoiEncontrada)
        contadorErros++;

    string letrasCorretasCompleta = string.Join("", letrasCorretas);

    if (palavraAleatoria == letrasCorretasCompleta)
    {
        Console.WriteLine($"Parabéns você acertou!");
        jogadorAcertou = true;
    }

    if (contadorErros > 5)
    {
        Console.WriteLine($"Game Over! A palavra era: {palavraAleatoria}");
        jogadorPerdeu = true;
        break;
    }
}

Console.WriteLine("Pressione ENTER para sair...");
Console.ReadLine();