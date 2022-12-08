using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Hr_Manager:Employee
    {
        private double kpi;
        public double Kpi {
            get { return kpi; }
            set { kpi = value; }
        }
        public double TotalSalary(double Kpi) {
            return MonthlySalary+= Kpi;
        }

        public Hr_Manager()
        {
           
        }

        public Hr_Manager(string name, string id, string dob, string join, string address, string bloodGroup, double monthly, double kpi)
        {
            this.Emp_Name = name;
            this.Emp_Id = id;
            this.Dob = Convert.ToDateTime(dob);
            this.JoiningDate = Convert.ToDateTime(join);
            this.Address = address;
            this.BloodGroup = bloodGroup;
            this.MonthlySalary =monthly+kpi;
            this.Kpi = kpi;
        }

        public void Show_Hr_Manager() {
            Show();
            Console.WriteLine("Monthly Salary: " + this.MonthlySalary);
        }
    }
}
