/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //using partial keyword//
    partial class Account
    {
        private string accountName;
        public string AccountName
        {
            get { return accountName; }
            set { accountName = value; }
        }
        private string accountNumber;
        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }
        private double balance;
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        //defalt parameter Constructor// 
        public Account() { }

        //Parameterized Constructor//
        public Account(string accountName, string accountNumber, double balance) {
            this.AccountName = accountName;
            this.AccountNumber = accountNumber;
            this.Balance = balance;
        }

        public void diposite(double x) {
            this.Balance += x;
        }
        public void withdraw(double y) {
            this.Balance -= y;
        }
        

        public void display() {
            Console.WriteLine("Account Name: " + this.AccountName);
            Console.WriteLine("Account Number: " + this.accountNumber);
            Console.WriteLine("Account Balance: " + this.balance);
            Console.WriteLine();
        }
    }
}



            ///Class from other file///

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    partial class Account
    {
        //Using Indexer//

        private string[] name;
       public string this[int index] {
            get { return this.name[index]; }
            set { this.name[index] = value; }
        }

        //using transfer method for transferring balance//
        public void transfer(Account ob2, double y) {
            this.Balance -= y;
            ob2.Balance += y;
        }

        //Constructor for initialized data//
        public Account(int x) {
            name = new string[] { "Tanvir Hasan", "Hasan Ibrahim", "Tareq Sir" };
        }

        
    }
}



                ///Main function for All the opeaation//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{

    class Program
    {        
        static void Main(string[]args)
        {
            Account a = new Account();
            a.AccountName = "Tanvir Hasan";
            a.AccountNumber = "21-44626-1";
            a.Balance = 2520;
            a.diposite(80);
            a.display();
           

            Account a1 = new Account("Hasan Khan", "456-213", 540);
            a1.withdraw(40);
            //Transfer to a1 Account//
            a.transfer(a1, 500);
            a1.display();

            Account a2 = new Account(5);

            Console.WriteLine(a2[0]);
        }
    }
}*/
