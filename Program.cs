/*using System;
public class Program{
    public static void Main(string[]args){
        Console.WriteLine("Enter your Number:");
        int num=Convert.ToInt32(Console.ReadLine());

        if(num<0 || num>100){
            Console.WriteLine("Wrong Number");
        }
        else if(num>=0 && num<50){
            Console.WriteLine("You are Fail");
        }
        else if(num>=50 && num<60){
            Console.WriteLine("Your Grade is D");
        }
        else if(num>=60 && num<70){
            Console.WriteLine("Your Grade is C");
        }
        else if(num>=70 && num<80){
            Console.WriteLine("Your Grade is B");
        }
        else if(num>=80 && num<90){
            Console.WriteLine("Your Grade is A");
        }
        else if(num>=90 && num<=100){
            Console.WriteLine("Your Grade is A+");
        }
    }
}*/
/*using System;
public class Program{
    public static void Main(string[]args){
        Console.WriteLine("Enter A Number:");
        int num=Convert.ToInt32(Console.ReadLine());

        switch(num){
            case 10:Console.WriteLine("10");
            break;
            case 20:Console.WriteLine("20");
            break;
            case 30:Console.WriteLine("30");
            break;
            default:Console.WriteLine("No renge");
            break;
        }
    }
}*/

/*using System;
public class Program{
    public static void Main(string[]args){
        for(int i=0;i<5;i++){
            for(int j=0;j<5;j++){
                Console.WriteLine(i+" "+j);
            }
        }
    }
}*/
/*using System;
public class Program{
    public static void Main(string[]args){
        int i=1;
        while(i<=5){
            int j=1;
            while(j<=5){
                Console.WriteLine(i+"  "+j);
                j++;
            }
            i++;
        }
    }
}*/
/*using System;
public class Program{
    public static void Main(string[]args){
        int[][]array=new int[3][]{
            new int[]{11,21,56,78},
            new int[]{2,5,6,7,98,5},
            new int[]{2,5}};
            for(int i=0;i<array.Length;i++){
                for(int j=0;j<array[i].Length;j++){
                    Console.Write(array[i][j]+" ");
                }
                Console.WriteLine();
            }
    }
}*/
/*using System;
public class Program{
    public void show(params int[]val){
        for(int i=0;i<val.Length;i++){
            Console.WriteLine(val[i]);
        }
    }
    public static void Main(string[]args){
        Program p=new Program();
        p.show(2,4,5,6,7,8,7);
    }
}*/
/*using System;
public class Program{
    public static void Main(string[]args){
         int []array={1,2,3,4,5,6,7};
       Array.Reverse(array);
       for(int i=0;i<array.Length;i++){
        Console.Write(array[i]+" ");
       }
    }
}*/

/*using System;
public class Program{
    int id;
    int age;
    string name="";

    public void show(){
        Console.WriteLine("Id: "+id);
        Console.WriteLine("Name: "+name);
        Console.WriteLine("Age: "+age);
        Console.WriteLine();
    }


    public static void Main(string[]args){
        Program p1=new Program();
        Program p2=new Program();

        p1.id=21;
        p1.name="Tanvir";
        p1.age=21;

        p2.id=44;
        p2.name="Hasan";
        p2.age=22;

        p1.show();
        p2.show();
    }
}*/
/*using System;
public class Program{
    public int id;
    public int age;
    
    public void show(){
        Console.WriteLine("ID: "+id);
        Console.WriteLine("Age: "+age);
    }
    // entity created in other class file//
    public class New{
    public static void Main(string[]args){
        Program p=new Program();
        p.id=21;
        p.age=23;

        p.show();
    }
}
}*/

/*using System;
public class Program{
    int id;
    string name="";
    int age;
    public void insert(int i,string n,int a){
        id=i;
        name=n;
        age=a;
    }
    public void display(){
        Console.WriteLine("ID: "+id);
        Console.WriteLine("Name: "+name);
        Console.WriteLine("Age: "+age);
    }
}

//Entity created in another class//
public class New{
    public static void Main(string[]args){
        Program p=new Program();
        p.insert(1,"Tanvir Hasan",22);
        p.display();
    }
}*/

/*public class Program{
    public Program(){
        System.Console.WriteLine("In the constructor");
    }    
    public static void Main(string[]args){
        Program p=new Program();
    }
}*/
/*using System;
public class Program{
    public int id;
    public String name="";
    public double salary;
    public Program(int i,string n,double s){
        id=i;
        name=n;
        salary=s;
    }
    public void display(){
        Console.WriteLine("Id: "+id);
        Console.WriteLine("Name: "+name);
        Console.WriteLine("Salary: "+salary);
    }
}
//Object created in another class//
using System;
public class New{
    public static void Main(string[]args){
        Program p=new Program(001,"Tanvir Hasan",45000);
        p.display();
    }
}*/
/*using System;
public class Program{
    public static void Main(String[]args){
        int[]array={1,2,3,4,5,6,7,8,9};
        int[]array1={20,43,65,7,8,88,91,100};
        foreach(int i in array){
            Console.Write(i+" ");
           
        }
        Console.WriteLine("\n");

        foreach(int i in array1){
            Console.Write(i+" ");
        }
    }
}*/
/*using System;
public class Program{
    public int id;
    public string name;
    public float salary;

    public Program(int id,string name,float salary){
        this.id=id;
        this.name=name;
        this.salary=salary;
    }
    public void display(){
        Console.WriteLine("ID: "+id);
        Console.WriteLine("Name: "+name);
        Console.WriteLine("Salary: "+salary);
        Console.WriteLine();
    }
   

}

//use this in another class or file//
public class New{
     public static void Main(string[]args){
        Program p=new Program(21,"Tanvir",35000);
        Program p1=new Program(32,"Kakon",50000);

        p.display();
        p1.display();
    }
}*/
/*using System;
public class Program{
    public int id;
    public string name;
    public float cgpa;
    public static string School="Faizur Rahman Ideal Institute";

    public Program(int id,string name,float cgpa){
        this.id=id;
        this.name=name;
        this.cgpa=cgpa;
    }
    public void display(){
        Console.WriteLine();
        Console.WriteLine("Student ID: "+id);
        Console.WriteLine("Student Name: "+name);
        Console.WriteLine("Student CGPA: "+cgpa);
        Console.WriteLine("Institute: "+School);
    }
}

//Object called in another Class//

using System;
public class New{
    public static void Main(string[]args){
        Program s=new Program(01,"Tamim",2.71F);
        Program s1=new Program(21,"Nasim",3.50F);

        s.display();
        s1.display();
    }
}*/
/*using System;
public class Program{
    public int id;
    public string name;
    public static int count=0;
    public Program(int id,string name){
        this.id=id;
        this.name=name;
        count++;
    }
    public void display(){
        Console.WriteLine();
        Console.WriteLine("ID No:"+id);
        Console.WriteLine("Name:"+name);

    }
}
// WE can use count as static//
using System;
public class New{
  public static void Main(string[]args){
    Program S1=new Program(21,"Tanvir");
    Program S2=new Program(11,"Tamal");

    S1.display();
    S2.display();
    Console.WriteLine("Total Studnet Input: "+Program.count);
  }  
}*/
/*using System;
public static class Program{
    public static int id=21;
    public static string name="Tanvir Hasan";
}

//called the static class in another class//
using System;
public class New{
    public static void Main(string[]args){
        Console.WriteLine("ID No: "+Program.id);
        Console.WriteLine("Name: "+Program.name);
    }
}*/
/*using System;
public class Program{
    public int id;
    public string name;
    public static float cgpa;
    public Program(int id,string name){
        this.id=id;
        this.name=name;
    }
    static Program(){
        cgpa=3.5F;
    }
    public void display(){
        Console.WriteLine();
        Console.WriteLine("ID: "+id);
        Console.WriteLine("Name: "+name);
        Console.WriteLine("CGPA: "+cgpa);
    }
}

using System;
public class New{
    public static void Main(string[]args){
        Program p=new Program(11,"Tanvir Hasan");
        Program p1=new Program(21,"Israt Jahan");
        p.display();
        p1.display();
    }
}*/
/*using System;
public struct Program{
	public int id;
	public string name;
	
	public void display(){
		Console.WriteLine(id);
		Console.WriteLine(name);
	}
}

// struct use in another class//
public class New{
	public static void Main(string[]args){
		Program p=new Program();
		p.id=21;
		p.name="Tamal";
		
		p.display();
	}
}*/

/*using System;
public struct Program{
	public int width,height;
	public Program(int width,int height){
		this.width=width;
		this.height=height;
	}
	public void AreaOfRectangle(){
		Console.WriteLine("Area of Rectangle: "+(width*height));
	}
}

public class New{
	public static void Main(){
		Program r=new Program(5,6);
		r.AreaOfRectangle();
	}
}*/
/*using System;
public struct Program{
	public int id;
	public string name;
	
	public Program(int i,string n){
		id=i;
		name=n;
	}
	public void dispaly(){
		Console.WriteLine();
		Console.WriteLine("Id No:"+id);
		Console.WriteLine("Name: "+name);
	}
}
//Struct use by Constructor//
public class New{
	public static void Main(){
		Program p=new Program(21,"Tanvir");
		p.dispaly();
		
	}	
}*/

/*using System;
public struct Program{
	public int id;
	public string name;
	public float cgpa;
	
	public void display(){
		Console.WriteLine();
		Console.WriteLine("ID No: "+id);
		Console.WriteLine("Name: "+name);
	}
}
//Struct use without Constructor//

public class New{
	public static void Main(){
		Program p=new Program();
		Program p1=new Program();
		
		p.id=001;
		p.name="Tanvir Hasan";
		p.cgpa=3.5f;
		
		p1.id=021;
		p1.name="Hanif";
		p1.cgpa=2.71f;
		
		p.display();
		p1.display();
	}
}*/

/*using System;
public struct Program{
	public int id;
	public string name;
	public double cgpa;
	public static string school="Faizur Rahman Ideal";
	
	public void display(){
		Console.WriteLine();
		Console.WriteLine("ID no: "+id);
		Console.WriteLine("Name: "+name);
		Console.WriteLine("CGPA: "+cgpa);
		Console.WriteLine("Institute: "+school);
	}
}
public class New{
	public static void Main(){
		Program p=new Program();
		Program p1=new Program();
		
		p.id=21;
		p.name="Tanvir";
		p.cgpa=3.57;
		
		p1.id=11;
		p1.name="Hasan";
		p1.cgpa=2.45;
		
		p.display();
		p1.display();
	}
}*/
/*using System;
public class Program{
    public static void Main(string[]args){
        int a, b;
            char c;
            Console.Write("Enter your first Value:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your second value:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your char:");
            c = Convert.ToChar(Console.ReadLine());

            float div = (a / b);

            if (c == '+')
            {
                Console.WriteLine(a + b);
            }
            else if (c == '-')
            {
                Console.WriteLine(a - b);
            }
            else if (c == '*')
            {
                Console.WriteLine(a * b);
            }
            else if (c == '/') {
                Console.WriteLine(div);
                }
    }
}*/

/*using System;
public class Program{
    private string name;
    public string Name{
        get{
            return name;
        }
        set{
            name=value
        }
    }
}*/
/*using System;
public class program{
    public static void Main(string[]args){
        for(int column=0;column<6;column++){
            for(int row=0;row<6;row++){
                if((row+column)%2==0){
                    Console.Write("X");
                }
                else if((row+column)%2!=0){
                    Console.Write("O");
                }
                else{
                    Console.Write("End");
                }

            }
            Console.WriteLine();
        }
    }
}*/


/*using System;
#nullable disable
public class Program{
    public static void Main(string[]args){
        Console.Write("Enter a letter: ");
        char a=Convert.ToChar(Console.ReadLine());
        if(a=='a'||a=='A'){
            Console.WriteLine("Vowel");
        }
        else if(a=='e'||a=='E'){
            Console.WriteLine("Vowel");
        }
        else if(a=='i'||a=='I'){
            Console.WriteLine("Vowel");
        }
        else if(a=='o'||a=='O'){
            Console.WriteLine("Vowel");
        }
        else if(a=='u'||a=='U'){
            Console.WriteLine("Vowel");
        }
        else{
            Console.WriteLine("Consonant");
        }
        /*if(a=='a'||a=='e'||a=='i'||a=='o'||a=='u'||a=='A'||a=='E'||a=='I'||a=='O'||a=='U'){
            Console.WriteLine("Vowel");
        }
        else{
            Console.WriteLine("Constant");
        }
    }
}*/
/*using System;
#nullable disable
public struct Student
    {
        public string name;
        public string id;
        public float cgpa;
        public DateTime date;
        public string bloodGroup;

    }

public class Program{
    public static void Main(string[]args){
       Student[] s = new Student[5];
            
            for (int i = 0; i < 2; i++) {
                Console.WriteLine("Please Enter your Student Info:");
                Console.Write("Enter your name: ");
                s[i].name = Console.ReadLine();
                Console.Write("Enter your id: ");
                s[i].id=Console.ReadLine();
                Console.Write("Enter your cgpa: ");
                s[i].cgpa=Convert.ToSingle(Console.ReadLine());
                Console.Write("Enter your Blood Group: ");
                s[i].bloodGroup=Console.ReadLine();
                Console.Write("Enter Your Date Of Birth: ");
                s[i].date=Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine();
            }
            for(int i=0;i<2;i++){
                Console.WriteLine("Your Entered Info:");
                Console.WriteLine("Name: "+s[i].name);
                Console.WriteLine("ID No: "+s[i].id);
                Console.WriteLine("Cgpa: "+s[i].cgpa);
                Console.WriteLine("Blood Group: "+s[i].bloodGroup);
                Console.WriteLine("Birth Date:"+s[i].date);
                Console.WriteLine();
            }
    }
}*/
/*using System;
public struct Student{
    public int id;
    public string name;
    public float cgpa;
    public DateTime dob;
    public void display(){
        Console.WriteLine();
        Console.WriteLine("Name: "+name);
        Console.WriteLine("ID No: "+id);
        Console.WriteLine("CGPA: "+cgpa);
        Console.WriteLine("Date Of Birth: "+dob);
        //this kind of DateTime show with time//
    }
}   

public class Program{
    public static void Main(string[]args){
       Student s=new Student();
       s.name="Tanvir Hasan";
       s.id=21;
       s.cgpa=3.54f;
       s.dob=Convert.ToDateTime("05-07-2002");

       s.display(); 
    }
}*/

            //Constructor in Structure//
            //data in put by constructure//
/*using System;
public struct Student{
    public string name;
    public int id;
    public float cgpa;
    

    public Student(int a){
        this.name="tanvir";
        this.id=21;
        this.cgpa=3.51f;
        
    }

    public void display(){
        Console.WriteLine();
        Console.WriteLine("Name: "+name);
        Console.WriteLine("ID no: "+id);
        Console.WriteLine("Cgpa: "+cgpa);
       
    }
}
public class Practice{
    public static void Main(string[]args){
        Student s=new Student(5);
        s.display();
    }
}*/

            //Parametarized Constructor with this keyword//


/*using System;
public struct Student{
    public string name;
    public int id;
    public double cgpa;
    public DateTime dob;

    public Student(string n,int i,double c,string d){
        this.name=n;
        this.id=i;
        this.cgpa=c;
        this.dob=Convert.ToDateTime(d);
    }

    public void display(){
        Console.WriteLine();
        Console.WriteLine("Name: "+name);
        Console.WriteLine("Id No: "+id);
        Console.WriteLine("Cgpa: "+cgpa);
        Console.WriteLine("Date Of Birth: "+dob.ToLongDateString());
        //This type fuction in datetime will show day,month,year//    
    }
}

public class Practice{
    public static void Main(string[]args){
        Student S1=new Student("Israt jahan Kakon",001,3.49,"07-05-2002");

        S1.display();
    }
}*/

        //parametarized Constructor with same name of peramiter //

/*using System;
public struct Student{
    public string name;
    public int id;
    public float cgpa;
    public DateTime dob;

    public Student(string name,int id,float cgpa,string dob){
        this.name=name;
        this.id=id;
        this.cgpa=cgpa;
        this.dob=Convert.ToDateTime(dob);
    }

    public void display(){
        Console.WriteLine();
        Console.WriteLine("Name: "+this.name);
        Console.WriteLine("Id No: "+this.id);
        Console.WriteLine("Cgpa: "+this.cgpa);
        Console.WriteLine("Date Of Birth: "+this.dob.ToShortDateString());
        //This type of datetype work with '/' //
    }
}
public class Practice{
    public static void Main(){
        Student s=new Student("Tanvir",21,3.21f,"02/05/2000");
        s.display();
    }
}*/

            //Acess Private field by Properties//
/*using System;

public struct Student{
    private string name;
    public string Name{
        get{return name;}
        set{name=value;}
    }
    private int id;
    public int Id{
        get{return id;}
        set{id=value;}
    }
    private double cgpa;
    public double Cgpa{
        get{return cgpa;} 
        set{cgpa=value;}
    }
    private DateTime dob;
    public DateTime Dob{
        get{return dob;}
        set{dob=value;}
    }

    public Student(string name,int id,double cgpa,string dob){
        this.name=name;
        this.id=id;
        this.cgpa=cgpa;
        this.dob=Convert.ToDateTime(dob);
    }
    public void dispaly(){
        //display data without call properties name//
        Console.WriteLine();
        Console.WriteLine("Name: "+name);
        Console.WriteLine("ID no: "+id);
        Console.WriteLine("Cgpa: "+cgpa);
        Console.WriteLine("Date of Birth: "+dob.ToShortDateString());
        //short date String will show only date long will show date with time//
    }
}
public class Practice{
    public static void Main(string[]args){
        Student S=new Student("Tanvir",321,3.54,"05-07-2002");
        S.dispaly();
    }
}*/

                ///Call Properties name to display date/// 
/*using System;
public struct Student{
    private string name;
    public string Name{
        get{return name;}
        set{name=value;}
    }
    private int id;
    public int Id{
        get{return id;}
        set{id=value;}
        
    }
    private float cgpa;
    public float Cgpa{
        get{return cgpa;}
        set{cgpa=value;}
    }
    private DateTime dob;
    public DateTime Dob{
        get{return dob;}
        set{dob=value;}
    }

   public Student(string name,int id,float cgpa,string dob){
    this.name=name;
    this.id=id;
    this.cgpa=cgpa;
    this.dob=Convert.ToDateTime(dob);

   }

   
}
public class Practice{
    public static void Main(string[]args){
        Student s=new Student("Tanvir Hasan",321,3.65f,"05/07/2002");
        Console.WriteLine();
        Console.WriteLine("Name: "+s.Name);
        Console.WriteLine("Id No: "+s.Id);
        Console.WriteLine("Cgpa: "+s.Cgpa);
        Console.WriteLine("Date Of Birth: "+s.Dob);
        //Display date with time//
    }
}*/

/*using System;
public struct BankAccount{
    private string name;
    public string Name{
        get{return name;}
        set{name=value;}
    }
    private string accountNo;
    public string AccountNo{
        get{return accountNo;}
        set{accountNo=value;}
    }
    private double balance;
    public double Balance{
        get{return balance;}
        set{balance=value;}
    }

    public BankAccount(int x){
        this.name="Tanvir Alom";
        this.accountNo="344566346";
        this.balance=2473488574.5;
        Console.WriteLine("Called from constructor");
    }
}

public class Practice{
    public static void Main(string[]args){
        BankAccount b=new BankAccount(5);
        Console.WriteLine();
        Console.WriteLine("Name: "+b.Name);
        Console.WriteLine("Account No: "+b.AccountNo);
        Console.WriteLine("Balance: "+b.Balance);
    }
}*/
    //Use else if//
/*using System;
#nullable disable
public class Practice{
    public static void Main(string[]args){
         Console.Write("Enter your mark:");
         int num=Convert.ToInt32(Console.ReadLine());
        if(num<=70||num<=74){
            Console.WriteLine("you got C+");
        }
        else if(num<=75||num<=79){
            Console.WriteLine("you got B");
        }
        else if(num<=80||num<=84){
            Console.WriteLine("You got B+");
        }
        else if(num<=85||num<=89){
            Console.WriteLine("You got A");
        }
        else if(num<=90||num<=100){
            Console.WriteLine("You got A+");
        }
        else {
            Console.WriteLine("You got Less then c+");
        }

    }
}*/

                    ///Optional Parameter///

/*using System;
public class Practice{
    public void Print(int a,int b=-1,int c=-1,int d=-1){
        int sum;
        if(c==-1 && d==-1){
            sum=a+b;
            Console.WriteLine(sum);
        }
        else if(b==-1&&d==-1){
            sum=a+c;
            Console.WriteLine(sum);
        }
        else if(b==-1&&c==-1){
            sum=a+d;
            Console.WriteLine(sum);
        }
        else if(d==-1){
            sum=a+b+c;
            Console.WriteLine(sum);
        }
        else if(c==-1){
            sum=a+b+d;
            Console.WriteLine(sum);
        }
        else if(b==-1){
            sum=a+c+d;
            Console.WriteLine(sum);
        }
        else{
            sum=a+b+c+d;
            Console.WriteLine(sum);
        }
    }
    public static void Main(string[]args){
        Practice p=new Practice();
        //p.Print(2,5);
        //p.Print(2,5,6);
        p.Print(2,c:5);
        p.Print(2,c:3,d:7);
        p.Print(2,3,5,6);


    }
}*/

            ///Named Parameter in constructor///

/*using System;

public struct Bank{
    public string name;
    public string accountNo;
    public double balance;

    public Bank(string name,string accountNo,double balance){
        this.name=name;
        this.accountNo=accountNo;
        this.balance=balance;
    }

    public void Display(){
        Console.WriteLine();
        Console.WriteLine("Name: "+name);
        Console.WriteLine("Account Number: "+accountNo);
        Console.WriteLine("Balance: "+balance);
    }
}

public class Practice{
    public static void Main(string[]args){
        Bank b=new Bank("Nishan","3245-123-431",5478.97);
        b.Display();
    }
}*/

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
        private string id;
        public string Id {
            get { return name; }
            set { name = value; }
        }
        private float cgpa;
        public float Cgpa {
            get { return cgpa; }
            set { cgpa = value; }
        }
                ///With Parameterized Constructor///
        public Student(string name,string id,float cgpa) {
            this.name = name;
            this.id = id;
            this.cgpa = cgpa;
        }

        public void display() { 
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Id: " + this.id);
            Console.WriteLine("Cgpa: " + this.cgpa);
            Console.WriteLine();
        }
        
    }
    
   public class Program
    {
        
        static void Main(string[]args)
        {
            ////Input Data by parameter///
            Student s = new Student("Tanvir Ahamed", "21-44626-1", 3.54f);
            s.display();
        }
    }
}*/