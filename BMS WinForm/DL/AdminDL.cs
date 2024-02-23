using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMS_WinForm.BL;
using System.IO;

namespace BMS_WinForm.DL
{
    class AdminDL
    {
        private static List<Admin> customersList = new List<Admin>();
        private static Admin current = new Admin();

        internal static List<Admin> CustomersList { get => customersList; set => customersList = value; }
        public static Admin Current { get => current; set => current = value; }

        public static void addCustomerToList(Admin Cus)
        {
            CustomersList.Add(Cus);
        }
        public static List<Admin> getCustomerList()
        {
            return CustomersList;
        }
        public static void setCurrent(MUser user)
        {
            foreach (Admin A in customersList)
            {
                if(user.UserName==A.UserName && user.Password==A.Password)
                {
                    current = A;
                }
            }
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
        
        public static void read_data(string path)
        {
            string record;
            StreamReader file = new StreamReader(path);
            while ((record = file.ReadLine()) != null)
            {
                string name = parse_data(record, 1);
                string userName = parse_data(record, 2);
                string password = parse_data(record, 3);
                string accountType = parse_data(record, 4);
                string city = parse_data(record, 5);
                string phoneNumber = parse_data(record, 6);
                string accountNum= parse_data(record, 7);
                if(accountNum=="")
                {
                    accountNum = "0";
                }

                double accountNumber = double.Parse(accountNum);
                string intialDep = parse_data(record, 8);
                if (intialDep == "")
                {
                    intialDep = "0";
                }
                double intialDeposit = double.Parse(intialDep);
                string totalMon = parse_data(record, 9);
                if (totalMon == "")
                {
                    totalMon = "0";
                }
                double totalMoney= double.Parse(totalMon);
                Admin A = new Admin(name, userName, password, accountType, city, phoneNumber, accountNumber, intialDeposit,totalMoney);
                addCustomerToList(A);
                
            }
            file.Close();

        }
        public static void storeCustomer(Admin A, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(A.Name + "," + A.UserName + "," + A.Password + "," + A.AccountType + "," + A.City + "," + A.PhoneNumber + "," + A.AccountNumber + "," + A.IntialDeposit + "," + A.IntialDeposit + "," + A.TotalMoney);
            file.Flush();
            file.Close();
        }
        public static void storeAllCustomers(string path)
        {
            StreamWriter file = new StreamWriter(path);
            foreach (Admin A in CustomersList)
            {
                file.WriteLine(A.Name + "," + A.UserName + "," + A.Password + "," + A.AccountType + "," + A.City + "," + A.PhoneNumber + "," + A.AccountNumber + "," + A.IntialDeposit + "," + A.TotalMoney);
            }
            file.Flush();
            file.Close();
        }
        public static void deleteCustomerFromList(Admin A)
        {
            for (int i = 0; i < customersList.Count; i++)
            {
                if(customersList[i].Name==A.Name && customersList[i].UserName == A.UserName && customersList[i].Password == A.Password)
                {
                    customersList.RemoveAt(i);
                }
            }
        }
        public static void editCustomerData(Admin previous,Admin update)
        {
            foreach (var A in customersList)
            {
                if (A.Name == previous.Name && A.UserName == previous.UserName && A.Password == previous.Password)
                {
                    A.Name = update.Name;
                    A.UserName = update.UserName;
                    A.Password = update.Password;
                    A.AccountNumber = update.AccountNumber;
                    A.AccountType = update.AccountType;
                    A.PhoneNumber = update.PhoneNumber;
                    A.IntialDeposit = update.IntialDeposit;
                    A.TotalMoney = update.TotalMoney;
                }

            }
        }
        public static double calculate()
        {
            double  total = 0;
            foreach (Admin A in CustomersList)
            {
                total = total + A.TotalMoney;
            }
            
            return total;
        }
    }
}
