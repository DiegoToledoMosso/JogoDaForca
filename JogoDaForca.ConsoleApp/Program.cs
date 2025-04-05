namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        //Versão 2: Exibir palavra oculta com traços
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

                string dicaDaPalavra = String.Join("", letrasEncontradas);

                Console.Clear();    
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Jogo da Forca");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("palavra secreta : " + palavraSecreta);
                Console.WriteLine("-------------------------------------");

                Console.Write("Digite uma letra: ");
                char chute = Console.ReadLine()[0]; // char obetém, apenas uma letra de uma palavra(caracter)

                Console.WriteLine(chute);

                Console.ReadLine(); 
            }




            

        }
    }
}
