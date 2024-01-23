using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_di_Nascità
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p=new Persona();
            Console.WriteLine("Quando sei nato?");
            p.DataDiNascità=DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Ora hai {0} anni", p.CalcolaEtà());
            Console.ReadLine();
        }
    }
}
