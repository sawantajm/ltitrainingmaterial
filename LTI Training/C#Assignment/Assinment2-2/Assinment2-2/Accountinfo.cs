using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assinment2_2
{
    abstract class Account
        {
        public double AccountNo { get; set; }

        public string BankName { get; set; }
        public double Accountbalance { get; set; }
        public string AccountPassword { get; set; }
        
        abstract public  void  Withdrow(double ammount);


        internal Account()
        {
           
            Console.WriteLine("Account Balance:");
            Accountbalance = float.Parse(Console.ReadLine());

            
        }


        internal Account(long accountno, string AccountPassword, double Accountbalance, string bankname)
        {
            this.AccountNo = accountno;
            this.AccountPassword = AccountPassword;
            this.Accountbalance = Accountbalance;
            this.BankName = bankname;

        }
    }

    class SavingAccount : Account
    {
       
        double total;
        public override void  Withdrow(double ammount)
        {
           
           
            
            if (ammount < minbal)
            {
               
                Console.WriteLine("you are not eligible for withdwowing Ammount");
            }
            else
            {
                total = Accountbalance - ammount;
                Console.WriteLine(total);
            }
        }

         double minbal;
        internal void Minbalance(double Minimumbal) 
        {
            this.minbal = Minimumbal;
            
        }
          internal void  DisplayAccount()
        {
            Console.WriteLine("Saving Account Information");
            Console.WriteLine("Account Balance:{0} || minimum Balance{1}:",Accountbalance,minbal);
        }
    }


    class CurrentAccount : Account
    {
        double total;
        public override void Withdrow(double ammount)
        {
         
            
         
            if (ammount < overdraftA)
            {
                Console.WriteLine("you are not eligible for withdwowing Ammount  Account Balance OverDraft");
                
            }
            else
            {
                total = Accountbalance - ammount;
                Console.WriteLine(total);
            }
        }
        double overdraftA;
        internal void Overdraft(double OverdraftLimitAmmount)
        {


            this.overdraftA = OverdraftLimitAmmount;
        }
        internal void DisplayAccount()

        {
            Console.WriteLine("Current Account information");
            Console.WriteLine("Account Balance :{0}||overDraft Balance{1}", Accountbalance ,overdraftA);
        }
    }
    internal class Accountinfo
    {
        static void Main()
        {
            double wbal;
            SavingAccount savingAccount = new SavingAccount();
            Console.WriteLine("Enetr Withdrow Ammount");
            wbal = Convert.ToDouble(Console.ReadLine());
            savingAccount.Minbalance(500);
            savingAccount.Withdrow(wbal);

            savingAccount.DisplayAccount();
            
            Console.WriteLine("CurrentAccount Account");

            CurrentAccount currentaccount = new CurrentAccount();
            Console.WriteLine("Enetr Withdrow Ammount");
            wbal = Convert.ToDouble(Console.ReadLine());
            currentaccount.Overdraft(80000);
            currentaccount.Withdrow(wbal);
            currentaccount.DisplayAccount();

        }
    }
}
