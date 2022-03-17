
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
	public interface ATM
	{
		public void withdraw(int accountNumber, double amount);
		
		public void checkBalance(int balance, int amount1);
	}


	public class ICICI :ATM
	{

		static void Main(string[] args)
		{

			ICICI iciciAtm = new ICICI();
			
			iciciAtm.checkBalance(56, 856);
			iciciAtm.withdraw(2300, -10);

		}
		public virtual void withdraw(int accountNumber, double amount)
		{
			
			try
			{
				if (amount <= 0)
				{
					throw new InvalidAmountException("Invalid amount; amount is less than 0");
				}
			}catch(InvalidAmountException e)
            {
				Console.WriteLine(e.Message);
            }
		}

		

		public virtual void checkBalance(int balance, int amount1)
		{
			try
			{
				if (balance < amount1)
				{
					throw new InsufficientFundsException(amount1 + " not available in your account");
				}
			}catch(InsufficientFundsException e)
            {
				Console.WriteLine(e.Message);
				
			}
		}
			

			void checkBalance()
			{
				throw new NotImplementedException();
			}
		}

		internal class InvalidAmountException : Exception
		{


			public InvalidAmountException() : base()
			{
			}
			public InvalidAmountException(string msg) : base(msg)
			{
			}
		}

		internal class InsufficientFundsException : Exception
		{
			public InsufficientFundsException() : base()
			{
			}
			public InsufficientFundsException(string msg) : base(msg)
			{
			}
		}
	}

