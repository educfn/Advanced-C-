using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Delegates.Lib
{
    public class FotoFiltro
    {
        public void Colorir(Foto foto)
        {
            //Algoritmo q faz Colorimento
            Console.Write("FotoFiltro > Colorir");
        }

        public void GerarThumb(Foto foto)
        {
            Console.Write("FotoFiltro > GerarThumb");
        }

        public void PretoBranco(Foto foto)
        {
            Console.Write("FotoFiltro > PretoBranco");
        }

        public void RedimensionarTamMedio(Foto foto)
        {
            Console.Write("FotoFiltro > RedimensionarTamMedio");
        }
    }
}
