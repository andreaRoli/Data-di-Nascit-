using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_di_Nascità
{
    internal class Persona
    { 
        public DateTime DataDiNascità { get; set; }

        public int CalcolaEtà()
        {
            int Anni=DateTime.Now.Year-DataDiNascità.Year;
           if(DateTime.Now.Day>=DataDiNascità.Day&&DateTime.Now.Month<DataDiNascità.Month || DateTime.Now.Day < DataDiNascità.Day && DateTime.Now.Month>=DataDiNascità.Month || DateTime.Now.Day<DataDiNascità.Day && DateTime.Now.Month<DataDiNascità.Month)
            {
                Anni = Anni - 1;
                return Anni;
            }
            else
            {
                return Anni;
            }
        }
    }
}
