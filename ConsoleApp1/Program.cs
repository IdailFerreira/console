using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ola 1");
            Console.WriteLine("ola 2");

            //variaveis e metodo criados a partir do dono do repositorio
            int primeiro_numero = 10,segundo_numero = 10,valor_final;
            public void soma()
            {
                valor_final = primeiro_numero + segundo_numero;
                Console.WriteLine(valor_final);
            }

            Console.WriteLine("Pressione alguma tecla para sair.");
            Console.ReadKey();
        }
    }
}