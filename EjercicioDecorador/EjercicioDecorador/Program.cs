using System;

namespace EjercicioDecorador
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();

            Console.WriteLine("Inserte ID:");
            string _cid = Console.ReadLine();
            Console.WriteLine("Inserte Importe:");
           string _cimporte = Console.ReadLine();
            Console.WriteLine("Inserte Naturaleza:");
           string _cnaturaleza = Console.ReadLine();

            cliente.ClienteCode(_cid, _cimporte, _cnaturaleza);
            Console.ReadKey();
        }
    }
}
