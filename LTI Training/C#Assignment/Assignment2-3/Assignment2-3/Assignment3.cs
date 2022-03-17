using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_3
{


   
        public interface atm
        {
            void withdraw(int accountNumber, double amount);
            void changePassword(int accountNumber, String oldPassword, String newPassword);
            void checkBalance();
	}
   

		public class icici : atm
		{

			public virtual void withdraw(int accountNumber, double amount)
			{
				// TODO Auto-generated method stub

				Console.WriteLine("Account Number of ICICI  is : " + accountNumber);
				Console.WriteLine("Amount in your SBI bank is  : " + amount);

			}
			public virtual void changePassword(int accountNumber, string oldPassword, string newPassword)
			{
				// TODO Auto-generated method stub
				Console.WriteLine("Old password OF ICICI was " + oldPassword);
				Console.WriteLine("ew password OF ICICI is : " + newPassword);
			}

			public virtual void checkBalance()
			{
				// TODO Auto-generated method stub

			}
			



			
	}
	
		internal class sbi : atm
		{
			public virtual void withdraw(int accountNumber, double amount)
			{
				Console.WriteLine("your account Number of SBI  is : " + accountNumber);
				Console.WriteLine("the amount in your SBI bank is  : " + amount);
			}
			public virtual void changePassword(int accountNumber, string oldPassword, string newPassword)
			{
				Console.WriteLine("the old password OF SBI was " + oldPassword);
				Console.WriteLine("your new password OF SBI is : " + newPassword);
			}

			public virtual void checkBalance() { }
			
		}
	
	public class Assignment3
    {

		public static void Main(string[] args)
		{
			sbi SbiAtm = new sbi();
			SbiAtm.changePassword(1234, "sham", "sham123");
			SbiAtm.checkBalance();
			SbiAtm.withdraw(1234, 658.85);

			icici iciciAtm = new icici();
			iciciAtm.changePassword(123456789, "ram", "ram123");
			iciciAtm.checkBalance();
			iciciAtm.withdraw(120080, 0.19526);
		}
    }

}
