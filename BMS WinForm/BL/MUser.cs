using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS_WinForm.BL
{
    class MUser
    {

       private string userName;
       private string password;

        public MUser(string userName, string password)
        {
            this.UserName = userName;
            this.Password = password;
        }

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
    }
}
