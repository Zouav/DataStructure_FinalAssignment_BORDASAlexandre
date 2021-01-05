using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure_Assignment_BORDAS
{
    class CustomDataList
    {
        List<Student> list = new List<Student>();

        public CustomDataList()
        {            
        }

        public List<Student> List
        {
            get { return list; }
        }

        public void Add(Student student)
        {
            this.list.Add(student);
            Console.WriteLine("Student successfully added !");
        }

        public void GetElement(int index)
        {
            if (this.list == null || this.list.Count == 0) Console.WriteLine("ERROR : there is no student in the list !");
            else
            {
                if (index >= this.list.Count)
                {
                    Console.WriteLine("ERROR : invalid index !");
                }
                else
                {
                    Console.WriteLine("Student at index " + index + " : " + this.list[index].FirstName + " " + this.list[index].LastName + " - " + this.list[index].StudentNumber + ", Average score of " + this.list[index].AverageScore);
                }
            }
        }

        public void RemoveByIndex(int index)
        {
            if (this.list == null || this.list.Count == 0) Console.WriteLine("ERROR : there is no student in the list !");
            else
            {
                if (index >= this.list.Count)
                {
                    Console.WriteLine("ERROR : invalid index !");
                }
                else
                {
                    this.list.RemoveAt(index);
                }
            }
        }

        public void RemoveFirst()
        {
            this.list.RemoveAt(0);
        }

        public void RemoveLast()
        {
            this.list.RemoveAt(this.list.Count - 1);
        }

        public void DisplayList()
        {
            int n = 1;

            if(this.list.Count > 0)
            {
                foreach (Student s in this.list)
                {
                    Console.WriteLine("Student #" + n + " : " + this.list[n - 1].FirstName + " " + this.list[n - 1].LastName + " - " + this.list[n - 1].StudentNumber + ", Average score of " + this.list[n - 1].AverageScore);
                    n++;
                }
            }
            else
            {
                Console.WriteLine("List is empty for the moment");
            }
        }

        public void PopulateWithSampleData()
        {
            Student s1 = new Student("ALEXANDRE", "BORDAS", "1", 80);
            Student s2 = new Student("ALICE", "DUBOIS", "2", 48);
            Student s3 = new Student("QUENTIN", "MULLER", "3", 96);
            Student s4 = new Student("AYMERIC", "NATIVEL", "4", 68);
            Student s5 = new Student("NICOLAS", "VANDERSTIGEL", "5", 74);
            Student s6 = new Student("THEO", "CHERRIER", "6", 53);
            Student s7 = new Student("MAX", "DOPPERS", "7", 39);

            this.list.Add(s1);
            this.list.Add(s2);
            this.list.Add(s3);
            this.list.Add(s4);
            this.list.Add(s5);
            this.list.Add(s6);
            this.list.Add(s7);
        }
        public int Count()
        {
            return this.list.Count;
        }

        public void Sort(string sortField, string sortDirection)
        {
            if(this.list.Count == 0)
            {
                Console.WriteLine("ERROR : list is empty ! a");
            }
            else
            {
                if(this.list.Count == 1)
                {
                    Console.WriteLine("ERROR : list must contain at least two students to be sorted !");
                }
                else
                {
                    switch(sortField)
                    {
                        case "fName":
                            {
                                for (int i = 0; i < this.list.Count - 1; i++)
                                {
                                    for (int j = i + 1; j > 0; j--)
                                    {
                                        if (string.Compare(this.list[j - 1].FirstName, this.list[j].FirstName) != -1)
                                        {
                                            Student temp = this.list[j - 1];
                                            this.list[j - 1] = this.list[j];
                                            this.list[j] = temp;
                                        }
                                    }
                                }
                                break;
                            }
                        case "lName":
                            {
                                for (int i = 0; i < this.list.Count - 1; i++)
                                {
                                    for (int j = i + 1; j > 0; j--)
                                    {
                                        if (string.Compare(this.list[j - 1].LastName, this.list[j].LastName) != -1)
                                        {
                                            Student temp = this.list[j - 1];
                                            this.list[j - 1] = this.list[j];
                                            this.list[j] = temp;
                                        }
                                    }
                                }
                                break;
                            }
                        case "id":
                            {
                                for (int i = 0; i < this.list.Count - 1; i++)
                                {
                                    for (int j = i + 1; j > 0; j--)
                                    {
                                        if (Convert.ToInt32(this.list[j - 1].StudentNumber) > Convert.ToInt32(this.list[j].StudentNumber))
                                        {
                                            Student temp = this.list[j - 1];
                                            this.list[j - 1] = this.list[j];
                                            this.list[j] = temp;
                                        }
                                    }
                                }
                                break;
                            }
                        case "avgScore":
                            {
                                for (int i = 0; i < this.list.Count - 1; i++)
                                {
                                    for (int j = i + 1; j > 0; j--)
                                    {
                                        if (this.list[j - 1].AverageScore > this.list[j].AverageScore)
                                        {
                                            Student temp = this.list[j - 1];
                                            this.list[j - 1] = this.list[j];
                                            this.list[j] = temp;
                                        }
                                    }
                                }
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("ERROR : incorrect field for sorting the list ! HEREEEEEEEEEe");
                                break;
                            }
                            
                    }
                   
                    if (sortDirection == "down") this.list.Reverse();

                    Console.WriteLine("List successfully sorted !");
                }
            }            
        }

        public void ReverseList()
        {
            if(this.list == null || this.list.Count <= 1)
            {
                Console.WriteLine("ERROR : list is empty !");
            }
            else
            {
                this.list.Reverse();
                Console.WriteLine("List succesfully reversed !");
            }
        }

        public void GetMaxElement(string sortField)
        {
            if(this.list.Count == 0)
            {
                Console.WriteLine("ERROR : list is empty !");
            }
            else
            {
                if(this.list.Count == 1)
                {
                    Console.WriteLine("Student : " + this.list[0].FirstName + " " + this.list[0].LastName + " - " + this.list[0].StudentNumber + ", Average score of " + this.list[0].AverageScore);
                }
                else
                {
                    Student temp = this.list[0];
                    switch (sortField)
                    {
                        case "fName":
                            {
                                for (int i = 0; i < this.list.Count; i++)
                                {
                                    if (string.Compare(this.list[i].FirstName, temp.FirstName) != 1) temp = this.list[i];
                                }
                                Console.WriteLine("Student with maximum first name : " + temp.FirstName + " " + temp.LastName + " - " + temp.StudentNumber + ", Average score of " + temp.AverageScore);
                                break;
                            }
                        case "lName":
                            {
                                for (int i = 0; i < this.list.Count; i++)
                                {
                                    if (string.Compare(this.list[i].LastName, temp.LastName) != 1) temp = this.list[i];
                                }
                                Console.WriteLine("Student with maximum last name : " + temp.FirstName + " " + temp.LastName + " - " + temp.StudentNumber + ", Average score of " + temp.AverageScore);
                                break;                            
                            }
                        case "id":
                            {
                                for (int i = 0; i < this.list.Count; i++)
                                {
                                    if (Convert.ToInt32(this.list[i].StudentNumber) > Convert.ToInt32(temp.StudentNumber)) temp = this.list[i];
                                }
                                Console.WriteLine("Student with maximum student number : " + temp.FirstName + " " + temp.LastName + " - " + temp.StudentNumber + ", Average score of " + temp.AverageScore);
                                break;
                            }
                        case "avgScore":
                            {
                                for (int i = 0; i < this.list.Count; i++)
                                {
                                    if (this.list[i].AverageScore > temp.AverageScore) temp = this.list[i];
                                }
                                Console.WriteLine("Student with maximum average score : " + temp.FirstName + " " + temp.LastName + " - " + temp.StudentNumber + ", Average score of " + temp.AverageScore);
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("ERROR : incorrect field !");
                                break;
                            }
                    }
                }
            }
        }

        public void GetMinElement(string sortField)
        {
            if (this.list.Count == 0)
            {
                Console.WriteLine("ERROR : list is empty !");
            }
            else
            {
                if (this.list.Count == 1)
                {
                    Console.WriteLine("Student : " + this.list[0].FirstName + " " + this.list[0].LastName + " - " + this.list[0].StudentNumber + ", Average score of " + this.list[0].AverageScore);
                }
                else
                {
                    Student temp = this.list[0];
                    switch (sortField)
                    {
                        case "fName":
                            {
                                for (int i = 0; i < this.list.Count; i++)
                                {
                                    if (string.Compare(this.list[i].FirstName, temp.FirstName) != -1) temp = this.list[i]; temp = this.list[i];
                                }
                                Console.WriteLine("Student with minimum first name : " + temp.FirstName + " " + temp.LastName + " - " + temp.StudentNumber + ", Average score of " + temp.AverageScore);
                                break;
                            }
                        case "lName":
                            {
                                for (int i = 0; i < this.list.Count; i++)
                                {
                                    if (string.Compare(this.list[i].LastName, temp.LastName) != -1) temp = this.list[i];
                                }
                                Console.WriteLine("Student with minimum last name : " + temp.FirstName + " " + temp.LastName + " - " + temp.StudentNumber + ", Average score of " + temp.AverageScore);
                                break;
                            }
                        case "id":
                            {
                                for (int i = 0; i < this.list.Count; i++)
                                {
                                    if (Convert.ToInt32(this.list[i].StudentNumber) < Convert.ToInt32(temp.StudentNumber)) temp = this.list[i];
                                }
                                Console.WriteLine("Student with minimum student number : " + temp.FirstName + " " + temp.LastName + " - " + temp.StudentNumber + ", Average score of " + temp.AverageScore);
                                break;
                            }
                        case "avgScore":
                            {
                                for (int i = 0; i < this.list.Count; i++)
                                {
                                    if (this.list[i].AverageScore < temp.AverageScore) temp = this.list[i];
                                }
                                Console.WriteLine("Student with minimum average score : " + temp.FirstName + " " + temp.LastName + " - " + temp.StudentNumber + ", Average score of " + temp.AverageScore);
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("ERROR : incorrect field !");
                                break;
                            }
                    }
                }
            }
        }
    }
}
