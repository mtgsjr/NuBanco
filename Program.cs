using System;

namespace DIO.Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta minhaconta = new Conta();
            minhaconta.Nome = "Marcos Tulio";
            Console.WriteLine("Nome: " + minhaconta.Nome);
        }
    }
}
