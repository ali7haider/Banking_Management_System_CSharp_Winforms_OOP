using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BMS_WinForm.BL;

namespace BMS_WinForm.DL
{
    class CustomerDL
    {
        private static List<Customer> depositList = new List<Customer>();
        private static List<Customer> withDrawList = new List<Customer>();
        private static List<Customer> transactList = new List<Customer>();
        private static List<Customer> receivedMoneyList = new List<Customer>();
        private static List<Customer> feedBackList = new List<Customer>();

        internal static List<Customer> DepositList { get => depositList; set => depositList = value; }
        internal static List<Customer> WithDrawList { get => withDrawList; set => withDrawList = value; }
        internal static List<Customer> TransactList { get => transactList; set => transactList = value; }
        internal static List<Customer> ReceivedMoneyList { get => receivedMoneyList; set => receivedMoneyList = value; }
        internal static List<Customer> FeedBackList { get => feedBackList; set => feedBackList = value; }

        public static void storeDepositHistory(string path,Customer details)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(details.UserName + "," + details.DepositMoney + "," + details.Date);
            file.Flush();
            file.Close();
        }
        public static void storeWithDrawHistory(string path, Customer details)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(details.UserName + "," + details.WithDrawMoney + "," + details.Date);
            file.Flush();
            file.Close();
        }
        public static void storeTransactHistory(string path, Customer details)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(details.UserName + "," + details.AccountNumber + "," + details.Purpose + "," + details.TransactMoney + "," + details.Date);
            file.Flush();
            file.Close();
        }
        public static void storeSendMoney(string path,Customer details,double accountNumber)
        {

            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(accountNumber + "," + details.AccountNumber + "," + details.Purpose + "," + details.TransactMoney + "," + details.Date);
            file.Flush();
            file.Close();
        }
        public static void storeFeedBack(string path, Customer details)
        {

            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(details.UserName + "," + details.FeedBack );
            file.Flush();
            file.Close();
        }

        public static void storeAllDepositHistory(string path)
        {

        }
        public static void readDepositHistory(string path)
        {
            string record;
            StreamReader file = new StreamReader(path);
            while ((record = file.ReadLine()) != null)
            {
                string userName = parse_data(record, 1);
                if (userName == AdminDL.Current.UserName)
                {
                    double money = double.Parse(parse_data(record, 2));
                    string date = parse_data(record, 3);
                    date = date + (parse_data(record, 4));
                    Customer C = new Customer(userName, money, date);
                    CustomerDL.depositList.Add(C);
                }
                

            }
            file.Close();

        }
        public static void readWithDrawHistory(string path)
        {
            string record;
            StreamReader file = new StreamReader(path);
            while ((record = file.ReadLine()) != null)
            {
                string userName = parse_data(record, 1);
                if (userName == AdminDL.Current.UserName)
                {
                    double money = double.Parse(parse_data(record, 2));
                    string date = parse_data(record, 3);
                    date = date + (parse_data(record, 4));
                    Customer C = new Customer(userName,date,money);
                    CustomerDL.withDrawList.Add(C);
                }


            }
            file.Close();

        }
        public static void readTransactHistory(string path)
        {
            string record;
            StreamReader file = new StreamReader(path);
            while ((record = file.ReadLine()) != null)
            {
                string userName = parse_data(record, 1);
                if (userName == AdminDL.Current.UserName)
                {
                    double accountNumber= double.Parse(parse_data(record, 2));
                    string purpose = parse_data(record, 3);
                    double transactMoney = double.Parse(parse_data(record, 4));
                    string date = parse_data(record, 5);
                    date = date + (parse_data(record, 6));
                    Customer C = new Customer(userName,accountNumber,purpose,transactMoney,date);
                    CustomerDL.transactList.Add(C);
                }


            }
            file.Close();

        }
        public static void readSendHistory(string path)
        {
            string record;
            StreamReader file = new StreamReader(path);
            while ((record = file.ReadLine()) != null)
            {
                double accountNumber = double.Parse(parse_data(record, 1));
                if (accountNumber == AdminDL.Current.AccountNumber)
                {
                    double accountNumber2 = double.Parse(parse_data(record, 2));
                    string purpose = parse_data(record, 3);
                    double receive = double.Parse(parse_data(record, 4));
                    string date = parse_data(record, 5);
                    date = date + (parse_data(record, 6));
                    Customer C = new Customer(accountNumber, accountNumber2, purpose, receive, date);
                    CustomerDL.ReceivedMoneyList.Add(C);
                }


            }
            file.Close();

        }
       
        public static void readFeedBacks(string path)
        {
            string record;
            StreamReader file = new StreamReader(path);
            while ((record = file.ReadLine()) != null)
            {
                string userName = parse_data(record, 1);
                string feedBack = parse_data(record, 2);
                Customer C = new Customer(userName, feedBack);
                CustomerDL.feedBackList.Add(C);

            }
            file.Close();

        }
        public static string parse_data(string record, int field)
        {
            string item = "";
            int comma = 1;
            for (int i = 0; i < record.Length; i++)
            {
                if (record[i] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[i];
                }
            }
            return item;
        }
        public static double calculateDepositMoney()
        {
            double total = 0;
            /*readDepositHistory("depositHistory.txt");*/
            foreach (Customer C in depositList)
            {
               
                if(AdminDL.Current.UserName==C.UserName)
                {
                    total = total + C.DepositMoney;
                    AdminDL.Current.TotalMoney = AdminDL.Current.TotalMoney + C.DepositMoney;


                }
            }
            
           /* transactList.Clear();*/
            return total;
        }
        public static double calculateWithDrawMoney()
        {
            double total = 0;
            /*readWithDrawHistory("withDrawHistory.txt");*/
            foreach (Customer C in withDrawList)
            {

                if (AdminDL.Current.UserName == C.UserName)
                {
                    total = total + C.WithDrawMoney;
                    AdminDL.Current.TotalMoney = AdminDL.Current.TotalMoney - C.WithDrawMoney;

                }
            }
            /*withDrawList.Clear();*/
            return total;
        }
        public static double calculateTransactMoney()
        {
            double total = 0;
           /* readTransactHistory("transactHistory.txt");*/
            foreach (Customer C in transactList)
            {

                if (AdminDL.Current.UserName == C.UserName)
                {
                    total = total + C.TransactMoney;
                    AdminDL.Current.TotalMoney = AdminDL.Current.TotalMoney - C.TransactMoney;

                }
            }
            /*transactList.Clear();*/
            return total;
        }
        public static double calculateReceivedMoney()
        {
            double total = 0;
            /*CustomerDL.readSendHistory("sendMoneyPath.txt");*/
            foreach (Customer C in receivedMoneyList)
            {
                    total = total + C.TransactMoney;
                    AdminDL.Current.TotalMoney = AdminDL.Current.TotalMoney + C.TransactMoney;                
            }
            /*receivedMoneyList.Clear();*/
            return total;
        }
        public static double totalMoney(double deposit,double withdraw,double transact,double recieve)
        {
            double total = 0;
            total = deposit + recieve;
            total = total - transact - withdraw;
            return total;
        }
    }
   
}
