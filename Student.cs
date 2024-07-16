using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zachary_Renyhart_Assignment_10._1._1
{
    public class Student
    {
        public int StudentId { get; set; }
        public string LastName { get; set; }
        public double GPA { get; set; }
        public char StudentGrade { get; set; }
        private string _firstName { get; set; }
        public string FirstName
        {
            get { return _firstName; }

            set { _firstName = value; }
        }
        private int _yearBorn;
        public int YearBorn
        {
            get { return _yearBorn; }

            set { _yearBorn = value; }
        }

    

        
        //This is a class constructor
    public Student()
        {
            //This is initializing the values of the class above
            StudentId = 0;
            FirstName = "Zack";
            YearBorn = 0;
            LastName = "Renyhart";
            GPA = 1.0;
            StudentGrade = 'B';
            
        }

    }

  
}
