using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Struct - Por Valor
            int i = null;

            //Class - Por referência
            //MySQ - Oracle - PostGreeSQL ... No SQL - Informações Opcionais
            Nullable<int> idade = null;
            int? idade2 = null;
            //ERRO: int Idade3 = null;
        }
    }
}