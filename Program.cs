using System.Data;
using System.Text.Json;
using System.Xml.Serialization;


namespace Zachary_Renyhart_Assignment_10._1._1
    
{
    
    internal class Program
    {
      
        static void Main(string[] args)
        {
            Student student = new Student();
            {
                student.StudentId = 1567239;
                student.FirstName = "Zachary";
                student.LastName = "Renyhart";
                student.YearBorn = 2000;
                student.StudentGrade = 'A';
                student.GPA = 3.6;
            }
            string jsonString = JsonSerializer.Serialize(student);
            //The resulting JSON string is stored in the jsonString variable.
            Console.WriteLine(jsonString);
            Console.WriteLine();

            

            string fileName = "Student.json";
            //string fileName = "Student.json"; assigns the filename to the variable fileName.
            string jsonString1 = JsonSerializer.Serialize(student);
            File.WriteAllText(fileName, jsonString1);
            // writes the contents of jsonString1 to the file specified by fileName.
            Console.WriteLine(File.ReadAllText(fileName));
            //reads the contents of the “Student.json” file and prints it to the console.


            XmlSerializer ser = new XmlSerializer(typeof(Student));
            DataSet ds = new DataSet("mydadaSet");
            DataTable t = new DataTable("table1");
            DataColumn c = new DataColumn("thing");
            t.Columns.Add(c);
            ds.Tables.Add(t);
            DataRow r;

            for (int i = 0; i < 10; i++)
            {
                r = t.NewRow();
                r[0] = "Thing" + i;
                t.Rows.Add(r);
            }
            TextWriter writer = new StreamWriter(fileName);
            ser.Serialize(writer, ds);
            writer.Close();

        }

        
    }
}
