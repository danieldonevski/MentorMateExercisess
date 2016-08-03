using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesSerialization
{
    class ExercisesSerializationProgram
    {
        static void Main(string[] args)
        {
            XMLSerialization ser = XMLSerialization.ReadIt();

            ser.WriteIt();

            Console.WriteLine("Name = {0}", ser.Name);
            Console.WriteLine("FacultyNumber = {0}", ser.FacultyNumber);
            Console.WriteLine();
    
            //JSONSerialization jsonSer = new JSONSerialization();
            //jsonSer.Name = "Gogo";
            //jsonSer.FacultyNumber = 12345;
            SerAndDes();
         
        }
        public static void SerAndDes()
        {
            JSONSerialization jsonSerClass = new JSONSerialization();
            jsonSerClass.Name = "Gogo";
            jsonSerClass.FacultyNumber = 123456;
            string jsonSer = JsonConvert.SerializeObject(jsonSerClass);
            File.WriteAllText("json.txt", jsonSer);

            JSONSerialization jsonDes = JsonConvert.DeserializeObject<JSONSerialization>(jsonSer);
            Console.WriteLine(jsonDes.Name);
            Console.WriteLine(jsonDes.FacultyNumber);
        }
    }
}
