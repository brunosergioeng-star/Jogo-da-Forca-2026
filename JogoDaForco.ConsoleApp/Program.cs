string palavraAleatoria = "ABACATE";

char[] letrasCorretas = new char[7];

for (int contadorLetras = 0; contadorLetras < 7; contadorLetras++)
{
    letrasCorretas[contadorLetras] = '_';
}

bool jogadorAcertou = false;

while (!jogadorAcertou)
{
    Console.Clear();

    for (int contadorLetras = 0; contadorLetras < 7; contadorLetras++)
    {
        Console.Write(letrasCorretas[contadorLetras]);
    }
    Console.WriteLine("Digite uma letra: ");
    char chute = Convert.ToChar(Console.ReadLine());

    //comparar a aletra com cada letra da palavra
    // descobrir o indice coreto

    for (int contadorPalavraAleatoria = 0; contadorPalavraAleatoria < palavraAleatoria.Length; contadorPalavraAleatoria++)
    {
        char letraAleatoriaAtual = palavraAleatoria[contadorPalavraAleatoria]; // 'A'

        if (chute == letraAleatoriaAtual)
        {
            letrasCorretas[contadorPalavraAleatoria] = chute;
        }
    }

    Console.ReadLine();
}