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

                string[] frutas = [
            "ABACATE",
                "ABACAXI",
                "ACEROLA",
                "ACAI",
                "ARACA",
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
                string[] paises = [
                    "Brasil",
                "Polonia",
                "Argentina"
                ];
                string[] animais = [
                    "Cachorro",
                "Gato",
                "Girafa"
                ];

                string escolha = null;            

                


                string[] historicoDeTentivas = new string[100];
                int contadorHistorico = 0;

                Random geradorDeNumeros = new Random();




                int indicePalavraEscolhidaum = geradorDeNumeros.Next(frutas.Length);
                int indicePalavraEscolhidadois = geradorDeNumeros.Next(animais.Length);
                int indicePalavraEscolhidatres = geradorDeNumeros.Next(paises.Length);

                string palavraSecreta = frutas[indicePalavraEscolhidaum];
                string palavraSecretadois = animais[indicePalavraEscolhidadois];
                string palavraSecretatres = paises[indicePalavraEscolhidatres];


                char[] letrasEncontradas = new char[palavraSecreta.Length];
                char[] letrasEncontradasdois = new char[palavraSecretadois.Length];
                char[] letrasEncontradastres = new char[palavraSecretatres.Length];



                Console.Clear();
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Jogo da Forca");
                Console.WriteLine("-------------------------------------");

                Console.WriteLine("Escolha uma categoria:");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("1 - frutas ");
                Console.WriteLine("2 - animais ");
                Console.WriteLine("3 - países ");
                Console.WriteLine("----------------------------------------");

                Console.Write("Digite sua escolha: ");
                string entrada = Console.ReadLine();


                if (entrada == "1")
                {
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
                        else if (quantidadeErros == 2)
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

                        historicoDeTentivas[contadorHistorico] = $"A letra chutada foi : {chute}";
                        contadorHistorico++;

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

                        Console.WriteLine("--------------------------------------------");
                        Console.WriteLine("Histórico de Tentativas");
                        Console.WriteLine("--------------------------------------------");

                        for (int contador = 0; contador < contadorHistorico; contador++)
                        {

                            Console.WriteLine(historicoDeTentivas[contador]);
                        }


                    } while (jogadorAcertou == false && jogadorEnforcou == false); // -- || significa "OU"   && significa "E"
                    contadorHistorico++;
                    Console.ReadLine();
                }
                else if (entrada == "2")
                {
                    for (int caractere = 0; caractere < letrasEncontradasdois.Length; caractere++)
                    {
                        //acessar o array no indicce 0
                        letrasEncontradasdois[caractere] = '_';
                    }

                    int quantidadeErros = 0;
                    bool jogadorEnforcou = false;
                    bool jogadorAcertou = false;

                    do
                    {
                        string dicaDaPalavra = String.Join("", letrasEncontradasdois);



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
                        else if (quantidadeErros == 2)
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

                        historicoDeTentivas[contadorHistorico] = $"A letra chutada foi : {chute}";
                        contadorHistorico++;

                        bool letraFoiEncontrada = false;                        

                        for (int contador = 0; contador < palavraSecretadois.Length; contador++)
                        {
                            char letraAtual = palavraSecretadois[contador];

                            if (chute == letraAtual)
                            {
                                letrasEncontradasdois[contador] = letraAtual;
                                letraFoiEncontrada = true;
                            }

                        }

                        if (letraFoiEncontrada == false)
                            quantidadeErros++;


                        dicaDaPalavra = String.Join("", letrasEncontradasdois);

                        jogadorAcertou = dicaDaPalavra == palavraSecretadois;
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
                            Console.WriteLine("Você errou a palavra secreta, Tente novamente!! a palavra secreta era : " + palavraSecretadois);
                            Console.WriteLine("-------------------------------------");

                        }

                        Console.WriteLine("--------------------------------------------");
                        Console.WriteLine("Histórico de Tentativas");
                        Console.WriteLine("--------------------------------------------");

                        for (int contador = 0; contador < contadorHistorico; contador++)
                        {

                            Console.WriteLine(historicoDeTentivas[contador]);
                        }


                    } while (jogadorAcertou == false && jogadorEnforcou == false); // -- || significa "OU"   && significa "E"
                    contadorHistorico++;
                    Console.ReadLine();
                }
                else if (entrada == "3")
                {
                    for (int caractere = 0; caractere < letrasEncontradastres.Length; caractere++)
                    {
                        //acessar o array no indicce 0
                        letrasEncontradastres[caractere] = '_';
                    }

                    int quantidadeErros = 0;
                    bool jogadorEnforcou = false;
                    bool jogadorAcertou = false;

                    do
                    {
                        string dicaDaPalavra = String.Join("", letrasEncontradastres);



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
                        else if (quantidadeErros == 2)
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

                        historicoDeTentivas[contadorHistorico] = $"A letra chutada foi : {chute}";
                        contadorHistorico++;

                        bool letraFoiEncontrada = false;

                        for (int contador = 0; contador < palavraSecretatres.Length; contador++)
                        {
                            char letraAtual = palavraSecretatres[contador];

                            if (chute == letraAtual)
                            {
                                letrasEncontradastres[contador] = letraAtual;
                                letraFoiEncontrada = true;
                            }

                        }

                        if (letraFoiEncontrada == false)
                            quantidadeErros++;


                        dicaDaPalavra = String.Join("", letrasEncontradastres);

                        jogadorAcertou = dicaDaPalavra == palavraSecretatres;
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
                            Console.WriteLine("Você errou a palavra secreta, Tente novamente!! a palavra secreta era : " + palavraSecretatres);
                            Console.WriteLine("-------------------------------------");

                        }

                        Console.WriteLine("--------------------------------------------");
                        Console.WriteLine("Histórico de Tentativas");
                        Console.WriteLine("--------------------------------------------");

                        for (int contador = 0; contador < contadorHistorico; contador++)
                        {

                            Console.WriteLine(historicoDeTentivas[contador]);
                        }


                    } while (jogadorAcertou == false && jogadorEnforcou == false); // -- || significa "OU"   && significa "E"
                    contadorHistorico++;
                    Console.ReadLine();

                }

                


                    
                }


        }
    }
}
