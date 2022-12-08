/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{

    class Program
    {
        private string name;
        public string Name {
            get { return name; }
            set { name = value; }
        }
        private string id;
        public string Id {
            get { return id; }
            set { id = value; }
        }
        private float cgpa;
        public float Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
       
        
        public Program() { }

        public Program(string name,string id,float cgpa,int age) {
            this.Name = name;
            this.Id = id;
            this.Cgpa = cgpa;
            this.Age = age;
        }
        public void scholarship()
        {
            if (Cgpa >= 3.75)
            {
                Console.WriteLine(Name);
            }
        }
        public void display() {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("CGPA: " + Cgpa);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine();
        }
        static void Main(string[]args)
        {
              Program s1 = new Program();
              s1.Name = "Tanvir Hasan Tamal";
              s1.Id = "21-44626-1";
              s1.Cgpa = 3.54f;
              s1.Age = 19;
              Program s2 = new Program("Hasan Imam", "17-3945-1", 3.76f, 21);
              s1.display();
              s2.display();
              Istudent s3 = new Istudent();
              s3.display();
              Class1 s4 = new Class1();
              s4.display();
              Istudent s5 = new Istudent("Imtiaz Hasan", "21-4736-2", 3.87f, 20);
              Class1 s6 = new Class1("Ibrahim mollah", "16-28374-3", 3.75f, 25);
              s5.display();
              s6.display();
              Console.WriteLine("Scholarship List:");
              s1.scholarship();
              s2.scholarship();
              s3.scholarship();
              s4.scholarship();
              s5.scholarship();
              s6.scholarship();
            Console.WriteLine();
            int a;
            int.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Your given value:"+a);

        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{       //Inheritance//
    class Istudent : Program
    {

        public Istudent()
        {
            this.Name = "Israt Jahan";
            this.Id = "20-23456-3";
            this.Cgpa = 3.5f;
            this.Age = 21;
        }
        public Istudent(string n,string i,float c,int a) {
            this.Name = n;
            this.Id = i;
            this.Cgpa = c;
            this.Age = a;
        }

    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{           //Multilevel Inheritance//
    class Class1 : Istudent {
        public Class1() {
            this.Name = "Imran Hossain";
            this.Id = "16-33843-2";
            this.Cgpa = 2.5f;
            this.Age = 23;
        }
        public Class1(string name, string id, float cgpa, int age) {
            this.Name = name;
            this.Id = id;
            this.Cgpa = cgpa;
            this.Age = age;
        }
    }
}*/