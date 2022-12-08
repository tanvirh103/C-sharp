                // Using Structure with Properties//
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public struct Student {
        private string name;
        public string Name {
            get { return name; }
            set { name = value; }
        }
        private int id;
        public int Id {
            get { return id; }
            set { id = value; }
        }
        private float cgpa;
        public float Cgpa {
            get { return cgpa; }
            set { cgpa = value; }

        }
        private DateTime dob;
        public DateTime Dob {
            get { return dob; }
            set { dob = value; }
        }
        
        public Student(string n,int i,float c,string d) {
            this.name = n;
            this.id = i;
            this.cgpa = c;
            this.dob = Convert.ToDateTime(d);
        }

        public void display() {
            Console.WriteLine();
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine("Id: " + this.Id);
            Console.WriteLine("Cgpa: " + this.Cgpa);
            Console.WriteLine("Date Of Birth :" + this.Dob.ToShortDateString());
        }
    }

     
    
   public class Program
    {
        
        static void Main(string[]args)
        {
            Student S = new Student("Tanvir", 21, 3.54f, "05-07-2002");
            S.display();
            Student S1 = new Student();
            S1.Name = "Israt";
            S1.Id = 43;
            S1.Cgpa = 2.7f;
            S1.Dob = Convert.ToDateTime("11-08-2004");
            S1.display();
        }
    }
}*/
