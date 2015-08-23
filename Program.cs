using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetofatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            string retorno = String.Empty;
            switch (str)
            {
                case "saudar":
                    retorno = clsteste.Saudar();
                    break;
                case "despedir": 
                    retorno = clsteste.Despedir();
                    break;
                default : 
                    retorno = str;
                    break;
            }
            Console.WriteLine(retorno);
        }
    }
}
