using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ExercisesSerialization
{
    public class XMLSerialization
    {
        public string Name { get; set; }
        public int FacultyNumber { get; set; }
        public static string file = "file.xml";

        public void WriteIt()
        {
            using (Stream strm = File.Create(file))
            {
                XmlSerializer ser = new XmlSerializer(this.GetType());
                ser.Serialize(strm, this);
            }
        }
        public static XMLSerialization ReadIt()
        {
            if (!File.Exists(file))
            {
                return new XMLSerialization { Name = "DefaultName", FacultyNumber = 1234567890 };
            }
            else
            {
                using (Stream strm = File.OpenRead(file))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(XMLSerialization));
                    return (XMLSerialization)ser.Deserialize(strm);
                }
            }
        }

    }
}
