using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace _01_Generics
{
    public class Serializador 
    {
        public static void Serializar(object obj)
        {
            StreamWriter sw = new StreamWriter(@"C:\MyCode\Udemy\AdvancedC#\Advanced C#\01_Generics\03_" + obj.GetType().Name + ".txt");

            string objSerializado = JsonConvert.SerializeObject(obj);

            sw.Write(objSerializado);
            sw.Close();
        }
        public static T Deserializar<T>()
        {
            StreamReader sw = new StreamReader(@"C:\MyCode\Udemy\AdvancedC#\Advanced C#\01_Generics\03_(NomeDaClasse).txt");
        }
    }
}
