﻿using System;
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
            Console.WriteLine("FotoFiltro > Colorir: " + foto.Nome);
        }

        public void GerarThumb(Foto foto)
        {
            Console.WriteLine("FotoFiltro > GerarThumb: " + foto.Nome);
        }

        public void PretoBranco(Foto foto)
        {
            Console.WriteLine("FotoFiltro > PretoBranco: " + foto.Nome);
        }

        public void RedimensionarTamMedio(Foto foto)
        {
            Console.WriteLine("FotoFiltro > RedimensionarTamMedio: " + foto.Nome);
        }
    }
}
