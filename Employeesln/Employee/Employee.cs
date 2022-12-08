using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Employee
    {
        private string emp_Name;
        public string Emp_Name {
            get { return emp_Name; }
            set { emp_Name = value; }
        }
        private string emp_Id;
        public string Emp_Id {
            get { return emp_Id; }
            set { emp_Id = value; }
        }
        private DateTime dob;
        public DateTime Dob
        {
            get { return dob; }
            set { dob = value; }
        }
        private DateTime joiningDate;
        public DateTime JoiningDate {
            get { return joiningDate; }
            set { joiningDate = value; }
        }
        private string address;
        public string Address {
            get { return address; }
            set { address = value; }
        }
        private string bloodGroup;
        public string BloodGroup {
            get { return bloodGroup; }
            set { bloodGroup = value; }
        }
        private double monthlySalary;
        public  double MonthlySalary
        {
            get { return monthlySalary; }
            set { monthlySalary = value; }
        }
        
        public Employee() {}

        public Employee(string name,string id,string dob,string join,string address,string bloodGroup,double monthly) {
            this.Emp_Name = name;
            this.Emp_Id = id;
            this.Dob =Convert.ToDateTime(dob);
            this.JoiningDate = Convert.ToDateTime(join);
            this.Address = address;
            this.BloodGroup = bloodGroup;
            this.MonthlySalary = monthly;
        }

        public void Show() {
            Console.WriteLine();
            Console.WriteLine("Name: " + this.Emp_Name);
            Console.WriteLine("Id No: " + this.Emp_Id);
            Console.WriteLine("Date Of Birth: " + this.Dob.ToShortDateString());
            Console.WriteLine("Joining Date: " + this.JoiningDate.ToShortDateString());
            Console.WriteLine("Address: " + this.Address);
            Console.WriteLine("Blood Group: " + this.BloodGroup);
            
        }
    }
}
