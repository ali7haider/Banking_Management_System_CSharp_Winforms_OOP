using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BMS_WinForm.BL;


namespace BMS_WinForm.DL
{
    class MUserDL
    {
        private static List<MUser> usersList = new List<MUser>();

        internal static List<MUser> UsersList { get => usersList; set => usersList = value; }

        static public void adduserstoList(MUser user)
        {
            UsersList.Add(user);
        }
        public List<MUser> getUsersList()
        {
            return UsersList;
        }
        static public MUser checkuser(MUser user)
        {
            if ((user.UserName == "Admin" || user.UserName == "admin") && user.Password == "1234")
            {
                return user;
            }
            foreach (MUser storedUser in UsersList)
            {
                if (storedUser.UserName == user.UserName && storedUser.Password == user.Password)
                {
                    return storedUser;
                }

            }
            return null;
        }
        static public bool isAdmin(MUser user)
        {
            if (user.UserName == "Admin" || user.UserName == "admin")
            {
                return true;
            }
            return false;
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
                string password = parse_data(record, 2);
                MUser u = new MUser(name, password);
                adduserstoList(u);
            }
            file.Close();

        }
        public static void storeUsersID(MUser U,string path)
        {
            StreamWriter file = new StreamWriter(path,true);
            file.WriteLine(U.UserName + "," + U.Password);
            file.Flush();
            file.Close();
        }
        public static void storeAllIds(string path)
        {
            StreamWriter file = new StreamWriter(path);
            foreach(MUser U in UsersList)
            {
                file.WriteLine(U.UserName + "," + U.Password);
            }
            file.Flush();
            file.Close();
        }
        public static void deleteIdFromList(string userName,string Password)
        {
            for (int i = 0; i < usersList.Count; i++)
            {
                if (userName ==usersList[i].UserName && Password==UsersList[i].Password)
                {
                    usersList.RemoveAt(i);
                }
            }
            
        }
        public static void editCustomerData(string namePrevious,string passwordPrevious,string nameUpdate,string passwordUpdate)
        {
            foreach (var U in usersList)
            {
                if (namePrevious ==U.UserName && passwordPrevious==U.Password)
                {
                    U.UserName = nameUpdate;
                    U.Password = passwordUpdate;
                }
            }
            
        }
    }
}
