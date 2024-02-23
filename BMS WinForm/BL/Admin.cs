using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS_WinForm.BL
{
    public class Admin
    {
        private string name;
        private string userName;
        private string password;
        private string accountType;
        private string city;
        private string phoneNumber;
        private double accountNumber;
        private double intialDeposit;
        private double totalMoney;

        public string Name { get => name; set => name = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string AccountType { get => accountType; set => accountType = value; }
        public string City { get => city; set => city = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public double AccountNumber { get => accountNumber; set => accountNumber = value; }
        public double IntialDeposit { get => intialDeposit; set => intialDeposit = value; }
        public double TotalMoney { get => totalMoney; set => totalMoney = value; }

        public Admin(string name, string userName, string password, string accountType, string city, string phoneNumber, double accountNumber, double intialDeposit,double totalMoney)
        {
            this.name = name;
            this.userName = userName;
            this.password = password;
            this.accountType = accountType;
            this.city = city;
            this.phoneNumber = phoneNumber;
            this.accountNumber = accountNumber;
            this.intialDeposit = intialDeposit;
            this.totalMoney = totalMoney;
        }
        public Admin()
        {

        }
        public Admin(string name, string userName, string password, string accountType, string city, string phoneNumber, double accountNumber,double totalMoney)
        {
            this.name = name;
            this.userName = userName;
            this.password = password;
            this.accountType = accountType;
            this.city = city;
            this.phoneNumber = phoneNumber;
            this.accountNumber = accountNumber;
            this.totalMoney = totalMoney;
        }
        public Admin(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }
        
    }
}
