﻿using System.Reflection.Metadata.Ecma335;

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
                    Console.WriteLine("palavra secreta : " + dicaDaPalavra);
                    Console.WriteLine("-------------------------------------");

                    Console.Write("Digite uma letra: ");
                    char chute = Console.ReadLine()[0]; // char obetém, apenas uma letra de uma palavra(caracter)

                    for (int contador = 0; contador < palavraSecreta.Length; contador++)
                    {
                        char letraAtual = palavraSecreta[contador];

                        if (chute == letraAtual)
                        {
                            letrasEncontradas[contador] = letraAtual;
                        }                       

                    }

                    Console.ReadLine();

                } while (jogadorAcertou == false || jogadorEnforcou == false); // -- || significa "OU"   && significa "E"
            }    

        }
    }
}
