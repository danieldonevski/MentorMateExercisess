using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace ExercisesSerialization
{ 
    [DataContract]
    public class Student
    {
        [JsonProperty("first-name")]
        public string FirstName { get; set; } = "Daniel";

        //[JsonProperty(PropertyName = "last-name")]
        [DataMember(Name = "lasst-name")]
        public string LastName { get; set; } = "Donevski";

        //[JsonProperty("student-course")]
        [DataMember(Name = "student-course")]
        public string StudentCourse { get; set; } = "Software Technologies And Design";

        [JsonProperty("faculty-number")]
        public int FacultyNumber { get; set; } = 1201481010;

        [JsonProperty("student-grade")]
        public float StudentGrade { get; set; } = 5.67f;

        public override string ToString()
        {
            return string.Format(
                "first-name = {0}\nlast-name = {1}\nstudent-course = {2}\nfaculty-number = {3}\nstudent-grade = {4}"
                ,FirstName, LastName, StudentCourse, FacultyNumber, StudentGrade);
        }
    }
}
