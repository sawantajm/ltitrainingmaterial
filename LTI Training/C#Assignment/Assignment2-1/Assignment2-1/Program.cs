using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_BankAccount
{


    public class Account
    {
       internal long accountNo { get; set; }
        internal double AccountBalance { get; set; }

       internal string AccountPassword { get; set; }

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


        internal Account(long accountno, string AccountPassword, double Accountbalance, string bankname)
        {
            this.accountNo = accountno;
            this.AccountPassword = AccountPassword;
            this.AccountBalance = Accountbalance;
            this.bankName = bankname;

        }
        internal void DisplayAccount()
        {
           
            Console.WriteLine("Account No :{0} || Account Password:{1} || Account Balance :{2} ||Bank Name: {3} ||minimum Balance{4}", accountNo, AccountPassword, AccountBalance, bankName);
        }


    }

    class SavingAccount : Account
    {
        double minbal;
        internal void Minbalance(double Minimumbal) 
        {
            this.minbal = Minimumbal;
            
        }
          internal void  DisplayAccount()
        {
            Console.WriteLine("Saving Account Information");
            Console.WriteLine("Account No :{0} || Account Password:{1} || Account Balance :{2} ||Bank Name: {3} ||minimum Balance{4}", accountNo, AccountPassword, AccountBalance, bankName,minbal);
        }

    }

    class CurrentAccount : Account
    {
        double overdraftA;
        internal void Overdraft(double OverdraftLimitAmmount)
        {


            this.overdraftA = OverdraftLimitAmmount;
        }
        internal void DisplayAccount()

        {
            Console.WriteLine("Current Account information");
            Console.WriteLine("Account No :{0} || Account Password:{1} || Account Balance :{2} ||Bank Name: {3} ||overDraft Balance{4}", accountNo, AccountPassword, AccountBalance, bankName,overdraftA);
        }
    }


    internal class BankDetails

    {
        static void Main()
        {
            SavingAccount savingAccount = new SavingAccount();
            savingAccount.Minbalance(500);
            savingAccount.DisplayAccount();


            CurrentAccount currentaccount = new CurrentAccount();
            currentaccount.Overdraft(80000);
            currentaccount.DisplayAccount();


        }
    }
}
