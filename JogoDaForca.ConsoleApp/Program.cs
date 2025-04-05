namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        //Definir estrutura básica do programa e receber input do usuário
        static void Main(string[] args)
        {

            while (true)
            {


                Console.Clear();    
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Jogo da Forca");
                Console.WriteLine("-------------------------------------");

                Console.Write("Digite uma letra: ");
                char chute = Console.ReadLine()[0]; // char obetém, apenas uma letra de uma palavra(caracter)

                Console.WriteLine(chute);

                Console.ReadLine(); 
            }




            

        }
    }
}
