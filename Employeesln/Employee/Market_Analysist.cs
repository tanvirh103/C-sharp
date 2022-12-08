using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Market_Analysist:Employee
    {
        private double commission;
        public double Commission {
            get { return commission; }
            set { commission = value; }
        }
        public double  TotalSalary(double Commission)
        {
             return MonthlySalary += Commission;
        }

        public Market_Analysist() {
            
        }

        public Market_Analysist(string name, string id, string dob, string join, string address, string bloodGroup, double monthly,double commission) {
            this.Emp_Name = name;
            this.Emp_Id = id;
            this.Dob = Convert.ToDateTime(dob);
            this.JoiningDate = Convert.ToDateTime(join);
            this.Address = address;
            this.BloodGroup = bloodGroup;
            this.MonthlySalary =monthly+commission ;
            this.Commission = commission;
        }
      

        public void Show_Market_Analysist() {
            Show();
            Console.WriteLine("Monthly Salary: " + this.MonthlySalary);
        }
    }
}
