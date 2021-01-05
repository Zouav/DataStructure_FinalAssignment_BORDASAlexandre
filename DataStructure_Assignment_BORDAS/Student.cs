using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure_Assignment_BORDAS
{
    class Student
    {
        string firstName;
        string lastName;
        string studentNumber;
        float averageScore;

        public Student(string fName, string lName, string sNumber, float avgScore)
        {
            this.firstName = fName.ToUpper();
            this.lastName = lName.ToUpper();
            this.studentNumber = sNumber;
            this.averageScore = avgScore;
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string StudentNumber
        {
            get { return studentNumber; }
            set { studentNumber = value; }
        }
        public float AverageScore
        {
            get { return averageScore; }
            set { averageScore = value; }
        }
    }
}
