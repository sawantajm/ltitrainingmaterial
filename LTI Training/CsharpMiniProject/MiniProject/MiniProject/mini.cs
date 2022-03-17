using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LumenWorks.Framework.IO.Csv;
using System.IO;
using System.Data.Common;
using System.Data;
namespace MiniProject
{
    class CsvFile
    {
        public DataTable csvtable = new DataTable();

        public void  Readcsv()
        {
            var readcsvfile = @"C:\Users\Sai\Downloads\complaints.csv";
            var reader = new StreamReader(System.IO.File.OpenRead(readcsvfile));
            var csvReader = new CsvReader(reader, true);
            {
                csvtable.Load(csvReader);
            }

            reader.Close();
        }
    }
    class Reuirement : CsvFile
    {
        public void GetcomplaintsbyYear()
        {
            int year;
            Console.WriteLine("Enter Year");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(csvtable.Rows.Count);
            for (int i = 0; i < csvtable.Rows.Count; i++)
            {
                char[] dateseprate = { '/', '-' };
                string datesplit = Convert.ToString(csvtable.Rows[i][0]);
                string[] datesplitc = datesplit.Split(dateseprate, 3, StringSplitOptions.None);

                int temp = Convert.ToInt32(datesplitc[2]);
                if (temp == year)
                {
                    Console.WriteLine(" Date Received:{0}\n Product:{1}\n SubProduct:{2} Issue:{3} \n SubIssue:{4}\n Company:{5}\n State:{6}\n ZipCode:{7}\n Submittedvia:{8}\n Date Sent to Company:{9}\n Company Response to customer:{10}\n Timely response?:{11}\nConsumer Disputed:{12}\n Client Response:{13}\n", csvtable.Rows[i][0], csvtable.Rows[i][1], csvtable.Rows[i][2], csvtable.Rows[i][3], csvtable.Rows[i][4], csvtable.Rows[i][5], csvtable.Rows[i][6], csvtable.Rows[i][7], csvtable.Rows[i][8], csvtable.Rows[i][9], csvtable.Rows[i][10], csvtable.Rows[i][11], csvtable.Rows[i][12], csvtable.Rows[i][13]);
                }
            }
        }
        public void BankComplaints()
        {
            string BankName;
            Console.WriteLine("Enter BankName:");
            BankName = Console.ReadLine();
            for (int j = 0; j < csvtable.Rows.Count; j++)
            {
                string temporay = Convert.ToString(csvtable.Rows[j][5]);
                if (temporay == BankName)
                {
                    Console.WriteLine("Date Received:{0}\n Product:{1}\n SubProduct:{2} Issue:{3}\n SubIssue:{4}\n Company:{5}\n State:{6}\n ZipCode:{7}\n Submittedvia:{8}\n Date Sent to Company:{9}\n Company Response to customer:{10}\n Timely response?:{11}\n Consumer Disputed:{12}\n Client Response:{13}\n", csvtable.Rows[j][0], csvtable.Rows[j][1], csvtable.Rows[j][2], csvtable.Rows[j][3], csvtable.Rows[j][4], csvtable.Rows[j][5], csvtable.Rows[j][6], csvtable.Rows[j][7], csvtable.Rows[j][8], csvtable.Rows[j][9], csvtable.Rows[j][10], csvtable.Rows[j][11], csvtable.Rows[j][12], csvtable.Rows[j][13]);

                }
            }
        }
        public void ComplaintUsingID()
        {
            Console.WriteLine("Enetr Complaint ID:");
            double compid = Convert.ToDouble(Console.ReadLine());
            for (int k = 0; k < csvtable.Rows.Count; k++)
            {
                double temp = Convert.ToDouble(csvtable.Rows[k][13]);
                if (temp == compid)
                {
                    Console.WriteLine(" Date Received:{0}\n Product:{1}\n SubProduct:{2} Issue:{3}\n SubIssue:{4}\n Company:{5}\n State:{6}\n ZipCode:{7}\n Submittedvia:{8}\n Date Sent to Company:{9}\n Company Response to customer:{10}\n Timely response?:{11}\n Consumer Disputed:{12}\n Client Response:{13}\n", csvtable.Rows[k][0], csvtable.Rows[k][1], csvtable.Rows[k][2], csvtable.Rows[k][3], csvtable.Rows[k][4], csvtable.Rows[k][5], csvtable.Rows[k][6],csvtable.Rows[k][7], csvtable.Rows[k][8], csvtable.Rows[k][9], csvtable.Rows[k][10],csvtable.Rows[k][11], csvtable.Rows[k][12], csvtable.Rows[k][13]);

                }
            }
        }
        public void CloseByTimeComplaits()
        {
            int index = 0;
            Console.WriteLine("Enter Complaint ID:");
            double compid = Convert.ToDouble(Console.ReadLine());
            for (int i = 0; i < csvtable.Rows.Count; i++)
            {
                double temp = Convert.ToDouble(csvtable.Rows[i][13]);
                if (temp == compid)
                    index = i;

            }
            char[] sep = { '/', '-' };
            string startdatestr = Convert.ToString(csvtable.Rows[index][0]);
            string[] startspl = startdatestr.Split(sep, 3, StringSplitOptions.None);
            string enddatestr = Convert.ToString(csvtable.Rows[index][9]);
            string[] endspl = enddatestr.Split(sep, 3, StringSplitOptions.None);
            DateTime startdate = Convert.ToDateTime(startspl[1] + '/' + startspl[0] + '/' + startspl[2]);
            DateTime enddate = Convert.ToDateTime(endspl[1] + '/' + endspl[0] + '/' + endspl[2]);
            TimeSpan totaltime = enddate - startdate;
            Console.WriteLine("Number of days took by the Bank to close the complaint:{0}", totaltime.Days);
        }
        public void closedcomplaints()
        {
            for (int j = 0; j < csvtable.Rows.Count; j++)
            {
                string str = Convert.ToString(csvtable.Rows[j][10]);
                if (str == "Closed" || str == "Closed with explanation")
                {
                    Console.WriteLine("Date Received:{0}\n Product:{1}\n SubProduct:{2} Issue:{3}\n SubIssue:{4}\n Company:{5}\n State:{6}\n ZipCode:{7}\n Submittedvia:{8}\n Date Sent to Company:{9}\n Company Response to customer:{10}\n Timely response?:{11}\n Consumer Disputed:{12}\n Client Response:{13}\n", csvtable.Rows[j][0], csvtable.Rows[j][1], csvtable.Rows[j][2], csvtable.Rows[j][3], csvtable.Rows[j][4], csvtable.Rows[j][5], csvtable.Rows[j][6], csvtable.Rows[j][7], csvtable.Rows[j][8], csvtable.Rows[j][9], csvtable.Rows[j][10], csvtable.Rows[j][11], csvtable.Rows[j][12], csvtable.Rows[j][13]);

                }
            }
        }
        public void Timelyresponsed()
        {
            for (int j = 0; j < csvtable.Rows.Count; j++)
            {
                if (Convert.ToString(csvtable.Rows[j][11]) == "Yes")
                {
                    Console.WriteLine("Date Received:{0}\n Product:{1}\n SubProduct:{2} Issue:{3}\n SubIssue:{4}\n Company:{5}\n State:{6}\n ZipCode:{7}\n Submittedvia:{8}\n Date Sent to Company:{9}\n Company Response to customer:{10}\n Timely response?:{11}\n Consumer Disputed:{12}\n Client Response:{13}\n", csvtable.Rows[j][0], csvtable.Rows[j][1], csvtable.Rows[j][2], csvtable.Rows[j][3], csvtable.Rows[j][4], csvtable.Rows[j][5], csvtable.Rows[j][6], csvtable.Rows[j][7], csvtable.Rows[j][8], csvtable.Rows[j][9], csvtable.Rows[j][10], csvtable.Rows[j][11], csvtable.Rows[j][12], csvtable.Rows[j][13]);

                }
            }
        }
        
        public void Complaint()
        {


            

            Console.WriteLine("Enter  Date:");
             string  DateRecive = Console.ReadLine();
            Console.WriteLine("Enter Product:");
            string product = Console.ReadLine();
            Console.WriteLine("Enter subproduct:");
            string subproduct = Console.ReadLine();
            Console.WriteLine("Enter Issue:");
            string issue = Console.ReadLine();
            Console.WriteLine("Enter subissue:");
            string subissue = Console.ReadLine();
            Console.WriteLine("Enter company:");
            string company = Console.ReadLine();
            Console.WriteLine("Enter state:");
            string state = Console.ReadLine();
            Console.WriteLine("Enter zipcode:");
            string zipcode = Console.ReadLine();
            Console.WriteLine("Enter Device through which complaint is submitted");
            string submittedvia = Console.ReadLine();
            Console.WriteLine("Enter Date sent to company:");
            string datesenttocompany = Console.ReadLine();
            Console.WriteLine("Enter Company response to consumer:");
            string companyrespose = Console.ReadLine();
            Console.WriteLine("Enter timely responded or not:");
            string timelyresponse = Console.ReadLine();
            Console.WriteLine("Enter Consumer disputed?");
            string consumerdipusted = Console.ReadLine();
            Console.WriteLine("Enter Complaint ID:");
            string complaintid = Console.ReadLine();

            var myfile = @"C:\Users\Sai\Downloads\complaints.csv";
            var csv = new StringBuilder();
            var newline = string.Format("DateRecive:{0},product:{1},subproduct:{2},issue:{3},subissue:{4},company:{5},state:{6},zipcode:{7},submittedvia:{8},datesenttocompany:{9},companyrespose:{10},timelyresponse:{11},consumerdipusted:{12},complaintid:{13}",
               DateRecive, product, subproduct, issue, subissue, company, state, zipcode, submittedvia, datesenttocompany, companyrespose, timelyresponse, consumerdipusted,complaintid);
            csv.AppendLine(newline);
            File.AppendAllText(myfile, csv.ToString());

           

            base.Readcsv();
        }

    }
    internal class Class1
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Loading Project........");
            
            Reuirement requirement = new Reuirement();
            requirement.Readcsv();

            int flage = 0;
            Console.Write("1.Display All complaints based on year Provided By User \n2.Display All the complaint based on the name of bank provided by user\n3.Display Compliant based on the complaint id provided by user\n4.Display the no of days took by the bank to close the complaint\n5.Display All the Complaints Closed/closed With Exception\n6.Display all the compliant which Recived a timely response\n7.Take input from user storing new Complaints\n8.Exit(0)");
            int complaints = Convert.ToInt32(Console.ReadLine());
            if (complaints == 1)
            {
                requirement.GetcomplaintsbyYear();
            }
            else if (complaints == 2)
            {
                requirement.BankComplaints();
            }
            else if (complaints == 3)
            {
                 requirement.ComplaintUsingID();
            }
           else  if (complaints == 4)
            {
            requirement.CloseByTimeComplaits();

            }
            else if (complaints == 5)
            {
             requirement.closedcomplaints();
            }
            else if (complaints == 6)
            {
              requirement.Timelyresponsed();
            }
           else  if (complaints == 7)
            {
                 requirement.Complaint();
            }
            else
            {
                flage = 1;
            }

        }
    }
}
