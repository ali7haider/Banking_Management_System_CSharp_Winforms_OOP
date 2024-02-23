using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS_WinForm.BL
{
    class Customer
    {
        private string userName;
        private double depositMoney;
        private double withDrawMoney;
        private double accountNumber;
        private double accountNumber2;
        private string purpose;
        private string date;
        private double transactMoney;
        private double receivedMoney;
        private string feedBack;
        
        public double DepositMoney { get => depositMoney; set => depositMoney = value; }
        public double WithDrawMoney { get => withDrawMoney; set => withDrawMoney = value; }
        public string Date { get => date; set => date = value; }
        public double TransactMoney { get => transactMoney; set => transactMoney = value; }
        public string UserName { get => userName; set => userName = value; }
        public double AccountNumber { get => accountNumber; set => accountNumber = value; }
        public string Purpose { get => purpose; set => purpose = value; }
        public double AccountNumber2 { get => accountNumber2; set => accountNumber2 = value; }
        public string FeedBack { get => feedBack; set => feedBack = value; }
        public double ReceivedMoney { get => receivedMoney; set => receivedMoney = value; }

        public Customer(string userName,double depositMoney,string date)
        {
            this.userName = userName;
            this.DepositMoney = depositMoney;
            this.Date = date;
            
        }
        public Customer(string userName,string date,double withDrawMoney )
        {
            this.userName = userName;
            this.withDrawMoney = withDrawMoney;
            this.Date = date;

        }
        public Customer(string userName,double accountNumber,string purpose,double transactMoney,string date)
        {
            this.userName = userName;
            this.accountNumber = accountNumber;
            this.purpose = purpose;
            this.transactMoney = transactMoney;
            this.date = date;
        }
        public Customer(double accountNumber2,double accountNumber, string purpose, double transactMoney, string date)
        {
            this.AccountNumber2=accountNumber2;
            this.accountNumber = accountNumber;
            this.purpose = purpose;
            this.transactMoney = transactMoney;
            this.date = date;
        }
        public Customer(string userName,string feedBack)
        {
            this.userName = userName;
            this.feedBack = feedBack;
        }

    }
}
