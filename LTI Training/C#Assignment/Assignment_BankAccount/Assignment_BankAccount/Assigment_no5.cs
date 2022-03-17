/*As a developer, you are asked to create a module to store details of a bank account. 
 You are asked to create a class Account with following fields:•accountNo•accountBalance•accountPasswordIn addition to above fields,
declare a class variable “bankName”to be shared by all objects of the class.For security reasons, 
above fields must not be directly accessed outside the class.
You need to generate getter and setter methods to let other classes
access or modify the object’s details.Write default and parameterized
constructors to allow creation of object in flexible manner.
Assignments on Java/C# 
-IWrite a member method called “displayAccount”in the Account class.
The “displayAccount” method whichdisplays all the details of the account.
Define a main class with “main” where account object iscreatedand call the display method to display account details




*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_BankAccount
{


   public  class Account
    {
        private long accountNo { get; set; }
        private double  AccountBalance { get; set; }

        private string AccountPassword { get; set; }

        public string bankName { get; set; }


        internal Account()
        {
            Console.WriteLine("Account Number:");
            accountNo = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Account Password");
            AccountPassword = Console.ReadLine();
            Console.WriteLine("Account Balance:");
            AccountBalance = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Bank Name: ");
            bankName = Console.ReadLine();
        }

         internal  Account(long accountno, string AccountPassword ,double  Accountbalance, string bankname)
        {
            this.accountNo = accountno;
            this.AccountPassword = AccountPassword;
            this.AccountBalance = Accountbalance;
            this.bankName = bankname;

        }


       internal void DisplayAccount()
        {
            Console.WriteLine("Account No :{0} || Account Password:{1} || Account Balance :{2} ||Bank Name: {3}",accountNo,AccountPassword,AccountBalance,bankName);
        }
    }

    class SavingAccount:Account
    {
        
        internal void Minbalance(int Minimumbal)
        {
            Console.WriteLine("Your Minimum Balance"+Minimumbal);
        }

    }

    class CurrentAccount : Account
    {internal void  Overdraft(int OverdraftLimitAmmount)
        {
           
            Console.WriteLine("overDraft Ammounrt is:{0}",OverdraftLimitAmmount);
        }
    }


    internal class BankDetails

    {
        static void Main()
        {
           SavingAccount savingAccount=new SavingAccount();
           savingAccount.Minbalance(500);
            savingAccount.DisplayAccount();

            
            CurrentAccount currentaccount=new CurrentAccount();
           currentaccount.Overdraft(80000);
           currentaccount.DisplayAccount();
         

        }
    }
}
