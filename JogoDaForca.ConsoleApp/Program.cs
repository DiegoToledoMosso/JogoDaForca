using System.Reflection.Metadata.Ecma335;

namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        //Versão 3: Verificação do input
        static void Main(string[] args)
        {

            while (true)
            {

                string palavraSecreta = "MELANCIA";

                char[] letrasEncontradas = new char[palavraSecreta.Length];

                for (int caractere = 0; caractere < letrasEncontradas.Length; caractere++)
                {
                    //acessar o array no indicce 0
                    letrasEncontradas[caractere] = '_';
                }

                int quantidadeErros = 0;
                bool jogadorEnforcou = false;
                bool jogadorAcertou = false;

                do
                {
                    string dicaDaPalavra = String.Join("", letrasEncontradas);

                    Console.Clear();
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Jogo da Forca");
                    Console.WriteLine("-------------------------------------");

                    if (quantidadeErros == 0)
                    {
                        Console.WriteLine(" ___________        ");
                        Console.WriteLine(" |/        |        ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine("_|____              ");
                        Console.WriteLine("-------------------------------------");
                    }

                    else if (quantidadeErros == 1)
                    {
                        Console.WriteLine(" ___________        ");
                        Console.WriteLine(" |/                ");
                        Console.WriteLine(" |         o        ");
                        Console.WriteLine(" |                      ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine("_|____              ");
                        Console.WriteLine("-------------------------------------");
                    }
                    else if(quantidadeErros == 2)
                    {
                        Console.WriteLine(" ___________        ");
                        Console.WriteLine(" |/                ");
                        Console.WriteLine(" |         o        ");
                        Console.WriteLine(" |         x            ");
                        Console.WriteLine(" |         x         ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine("_|____              ");
                        Console.WriteLine("-------------------------------------");
                    }
                    else if (quantidadeErros == 3)
                    { 
                        Console.WriteLine(" ___________        ");
                        Console.WriteLine(" |/                ");
                        Console.WriteLine(" |         o        ");
                        Console.WriteLine(" |        /x\\             ");
                        Console.WriteLine(" |         x         ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine("_|____              ");
                        Console.WriteLine("-------------------------------------");
                    }
                    else if (quantidadeErros == 4)
                    {
                        Console.WriteLine(" ___________        ");
                        Console.WriteLine(" |/                ");
                        Console.WriteLine(" |         o        ");
                        Console.WriteLine(" |        /x\\             ");
                        Console.WriteLine(" |         x         ");
                        Console.WriteLine(" |        / \\        ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine("_|____              ");
                        Console.WriteLine("-------------------------------------");
                    }
                    else if (quantidadeErros == 4)
                    {
                        Console.WriteLine(" ___________        ");
                        Console.WriteLine(" |/                ");
                        Console.WriteLine(" |         o        ");
                        Console.WriteLine(" |        /x\\             ");
                        Console.WriteLine(" |         x         ");
                        Console.WriteLine(" |        / \\        ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine("_|____              ");
                        Console.WriteLine("-------------------------------------");
                    }
                    else if (quantidadeErros == 5)
                    {
                        Console.WriteLine(" ___________        ");
                        Console.WriteLine(" |/                ");
                        Console.WriteLine(" |         o        ");
                        Console.WriteLine(" |        /x\\             ");
                        Console.WriteLine(" |         x         ");
                        Console.WriteLine(" |        / \\        ");
                        Console.WriteLine(" |       -----          ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine("_|____              ");
                        Console.WriteLine("-------------------------------------");
                    }

                    Console.WriteLine("palavra secreta : " + dicaDaPalavra);
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Quantidade de erros : " + quantidadeErros);
                    Console.WriteLine("-------------------------------------");

                    Console.Write("Digite uma letra: ");
                    char chute = Console.ReadLine()[0]; // char obetém, apenas uma letra de uma palavra(caracter)

                    bool letraFoiEncontrada = false;

                    for (int contador = 0; contador < palavraSecreta.Length; contador++)
                    {
                        char letraAtual = palavraSecreta[contador];

                        if (chute == letraAtual)
                        {
                            letrasEncontradas[contador] = letraAtual;
                            letraFoiEncontrada = true;
                        }
                        
                    }

                    if (letraFoiEncontrada == false)
                        quantidadeErros++;


                    dicaDaPalavra = String.Join("", letrasEncontradas);

                    jogadorAcertou = dicaDaPalavra == palavraSecreta;
                    // O jogador poderá cometer 5 erros antes de perder.
                    jogadorEnforcou = quantidadeErros == 6;


                    if (jogadorAcertou)
                    {
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("Você acertou a palavra secreta, Parabéns!!");
                        Console.WriteLine("-------------------------------------");

                    }
                    else if (jogadorEnforcou)
                    {
                        Console.Clear();
                        Console.WriteLine(" ___________        ");
                        Console.WriteLine(" |/        |        ");
                        Console.WriteLine(" |         o        ");
                        Console.WriteLine(" |        /x\\             ");
                        Console.WriteLine(" |         x         ");
                        Console.WriteLine(" |        / \\        ");
                        Console.WriteLine(" |       -----          ");
                        Console.WriteLine(" |                  ");
                        Console.WriteLine("_|____              ");                                              
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("Você errou a palavra secreta, Tente novamente!! a palavra secreta era : " + palavraSecreta);
                        Console.WriteLine("-------------------------------------");

                    }

                } while (jogadorAcertou == false && jogadorEnforcou == false); // -- || significa "OU"   && significa "E"

                Console.ReadLine();
            }    
            

        }
    }
}
