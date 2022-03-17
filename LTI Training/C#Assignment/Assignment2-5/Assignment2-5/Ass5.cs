using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assignment2_5.AccountDAo.AccountDao;

namespace Assignment2_5
{
	public interface AccountDAo
	{
		interface AccountDao
		{
			public interface AccountDao
			{
				void addAnAccount(AccountDao account);
				void withdraw(int accountNumber, double amount);
				void checkBalance();
				void changePassword(int accountNumber, string oldPassword, string newPassword);
				void getAccountDetails(int accountNumber);
			}

			void withdraw(int v1, int v2);
			void getAccountDetails(int v);
			void checkBalance();
		}
	}
	internal class Ass5
	{
		public class InMemoryAccountDaoImpl : AccountDao, IComparable<AccountDao>
		{
			internal int accountNumber;
			internal double account_balance;
			internal string name;
			public InMemoryAccountDaoImpl(int accountNumber, double account_balance, string name) : base()
			{
				this.accountNumber = accountNumber;
				this.account_balance = account_balance;
				this.name = name;
			}
			public virtual void AddAnAccount(AccountDao account)
			{

				IList<AccountDao> list1 = new List<AccountDao>();
				list1.Add(new InMemoryAccountDaoImpl(accountNumber, account_balance, name));
			}

			public virtual void withdraw(int accountNumber, double amount)
			{

				account_balance = account_balance - amount;
				Console.WriteLine(amount + " was withdrawn from " + accountNumber);
			}

			public virtual void checkBalance()
			{
				Console.WriteLine("the balance is " + account_balance);

			}

			public virtual void changePassword(int accountNumber, string oldPassword, string newPassword)
			{
				Console.WriteLine(accountNumber + " old password was " + oldPassword + "new password is " + newPassword);
			}

			public virtual void getAccountDetails(int accountNumber)
			{
				Console.WriteLine(accountNumber);
				Console.WriteLine("the balance is " + account_balance);
				Console.WriteLine("the name of the account holder is " + name);

			}

			public void withdraw(int v1, int v2)
			{
				throw new NotImplementedException();
			}

			public int CompareTo([System.Diagnostics.CodeAnalysis.AllowNull] AccountDao other)
			{
				throw new NotImplementedException();
			}

			void AccountDao.addAnAccount(AccountDao account)
			{
				throw new NotImplementedException();
			}
		}
	}
	class AccountMain
	{
		public static void Main(string[] args)
		{
			AccountDao a1 = new Ass5.InMemoryAccountDaoImpl(123456, 500000, "Ajay");
			
			a1.checkBalance();
			a1.getAccountDetails(123456);


			AccountDao a2 = new Ass5.InMemoryAccountDaoImpl(123457, 556000, "Ram");
			a2.getAccountDetails(123457);
			a2.withdraw(123457, 56000);
			a2.checkBalance();
		}
	}
}
