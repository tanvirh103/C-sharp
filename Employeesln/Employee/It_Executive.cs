using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class It_Executive:Employee
    {
        private double projectBonus;
        public double ProjectBonus
        {
            get { return projectBonus; }
            set { projectBonus = value; }
        }
        public  double TotalSalary(double ProjectBonus)
        {

             return MonthlySalary+=ProjectBonus;
            

        }

        public It_Executive() {
            
        }
       
        public It_Executive(string name, string id, string dob, string join, string address, string bloodGroup, double monthly, double project)
        {
            this.Emp_Name = name;
            this.Emp_Id = id;
            this.Dob = Convert.ToDateTime(dob);
            this.JoiningDate = Convert.ToDateTime(join);
            this.Address = address;
            this.BloodGroup = bloodGroup;
            this.ProjectBonus = project;
            this.MonthlySalary =monthly+project;

        }

        public void Show_It_Executive()
        {

            Show();
            Console.WriteLine("Monthly Salary: " +this.MonthlySalary);
        }
    }
}
