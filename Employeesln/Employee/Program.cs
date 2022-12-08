using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
   
    class Program
    {

        static void Main(string[] args)
        {
            Market_Analysist m1 = new Market_Analysist("Tanvir", "21-44626-1", "01-05-2002", "05-07-2022", "Dhaka", "B+", 5000, 200);
            Market_Analysist m2 = new Market_Analysist();
            m2.Emp_Name = "Imam";
            m2.Emp_Id = "4858";
            m2.Dob = Convert.ToDateTime("05-09-2001");
            m2.JoiningDate = Convert.ToDateTime("03-09-2022");
            m2.Address = "Badda";
            m2.BloodGroup = "A+";
            m2.MonthlySalary = 650;
            m2.TotalSalary(120);
            m1.Show_Market_Analysist();
            m2.Show_Market_Analysist();

            It_Executive i = new It_Executive();
            It_Executive i2 = new It_Executive("Rahman", "21-4456-1", "05-07-2002", "04-05-2034", "Bangladesh", "A-", 3490, 10);
            i.Emp_Name = "Hamid";
            i.Emp_Id = "54 - 234";
            i.Dob = Convert.ToDateTime("05-03-20");
            i.JoiningDate = Convert.ToDateTime("01-01-22");
            i.BloodGroup = "o-";
            i.Address = "Mirpur";
            i.MonthlySalary = 900;
            i.TotalSalary(500);

            i.Show_It_Executive();
            i2.Show_It_Executive();

            Hr_Manager h = new Hr_Manager("Israt", "21-4858-3", "11-08-2004", "12/31/2022", "Kuril", "B-", 9000, 1000);
            Hr_Manager h1 = new Hr_Manager();
            h1.Emp_Name = "Habib";
            h1.Emp_Id = "54 - 234";
            h1.Dob = Convert.ToDateTime("11-29-1990");
            h1.JoiningDate = Convert.ToDateTime("12-03-2002");
            h1.BloodGroup = "O+";
            h1.Address = "B-Baria";
            h1.MonthlySalary = 900;
            h1.TotalSalary(500);

            h1.Show_Hr_Manager();
            h.Show_Hr_Manager();

            Part_Time p1 = new Part_Time("Tanvir Hasan", "21-44626-1", "05-07-2002", "09-27-2025", "Aftab Nagar", "B+", 5000);
            Part_Time p2 = new Part_Time();
            p2.Emp_Name = "Korim";
            p2.Emp_Id = "31-3485";
            p2.Dob = Convert.ToDateTime("12-31-1999");
            p2.JoiningDate = Convert.ToDateTime("10-08-2017");
            p2.Address = "Gazipur";
            p2.BloodGroup = "AB+";
            p2.MonthlySalary = 6054;

            p1.Show_Part_time();
            p2.Show_Part_time();

            
            
          
            
            






        }
    }
}
