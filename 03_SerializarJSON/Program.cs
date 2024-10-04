using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using _00_Biblioteca;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace _03_SerializarXML
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario() { Nome = "Maria Costa Silva", CPF = "333.333.333-33", Email = "maria.costa@gmail.com" };

            string stringObjetoSerializado = JsonConvert.SerializeObject(usuario);

            StreamWriter sw = new StreamWriter(@"C:\MyCode\Udemy\AdvancedC#\Advanced C#\03_SerializarXML.xml");
            sw.WriteLine(stringObjetoSerializado);
            sw.Close();

        }
    }
}