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


            //Ser();
            DeSer();
         
        }
        public static void Ser()
        {
            Student student = new Student();
            string jsonSer = JsonConvert.SerializeObject(student);
            File.WriteAllText("json.txt", jsonSer);

     
        }
        public static void DeSer()
        {
            string jsonDeSerString = File.ReadAllText("json.txt");
            Student jsonDes = JsonConvert.DeserializeObject<Student>(jsonDeSerString);
            Console.WriteLine(jsonDes.FirstName);
        }
    }
}
