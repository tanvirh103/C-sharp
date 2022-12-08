using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Part_Time:Employee
    {
        public Part_Time() {

        }
        public Part_Time(string name, string id, string dob, string join, string address, string bloodGroup, double monthly) {
            this.Emp_Name = name;
            this.Emp_Id = id;
            this.Dob = Convert.ToDateTime(dob);
            this.JoiningDate = Convert.ToDateTime(join);
            this.Address = address;
            this.BloodGroup = bloodGroup;
            this.MonthlySalary = monthly;
        }
        public void Show_Part_time() {
            Show();
            Console.WriteLine("Monthly Salary: " + this.MonthlySalary);
        }
    }
}
