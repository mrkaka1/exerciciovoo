using System;

class V
{
    static void Main(string[] args)
    {
       
            VOO W = new VOO(01, new DateTime(2022, 07, 30));
            Console.WriteLine($"Numero do Vôo: {W.numbervoo}");
            Console.WriteLine($"Data do Vôo: {W.GetData()}\n\n");

            Console.WriteLine($"Digite a poltrona desejada e veja se ela esta ocupado ou não: {W.Verifica(15)} \n\n");
            Console.WriteLine($"Ocupar a Cadeira: {W.Ocupa(15)}\n");
            Console.WriteLine($"Proxima poltrona Livre {W.ProximoLivre()}");



            Console.WriteLine($"Numero de Vagas Livres: {W.Vagas()}");
            

        Console.ReadKey();
    }
}