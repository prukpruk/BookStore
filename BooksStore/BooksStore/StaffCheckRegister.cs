using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksStore
{
    class StaffCheckRegister
    {
        private string Email;
        private string Password;
        private string Password1;
        private string IdCard;
        private string Address;
        private string emailFromPick;

        public StaffCheckRegister(string email, string password0, string password1, string idcard, string address)
        {
            Email = email;
            Password = password0;
            Password1 = password1;
            IdCard = idcard;
            Address = address;
        }
        public bool CheckNullOutput
        {
            get { return CheckNull(); }
        }
        public bool EmailCheckCountOutput
        {
            get { return EmailCheckCount(); }
        }
        public bool PasswordCheckCountOutput
        {
            get { return PasswordCheckCount(); }
        }
        public bool PasswordCheckOutput
        {
            get { return PasswordCheck(); }
        }
        public bool IDCardCheckCountOutput
        {
            get { return IDCardCheckCount(); }
        }
        public bool AddressCheckCountOutput
        {
            get { return AddressCheckCount(); }
        }
        public bool CheckDoubleEmail
        {
            get { return DoubleDataEmailCheck(); }
        }
        private bool CheckNull()
        {
            bool check;
            if (Email == "" || Password == "" || IdCard == "" || Address == "")
            {
                check = false;
            }
            else
            {
                check = true;
            }
            return check;
        }
    
        private bool EmailCheckCount()
        {
            bool check;
            if (Email.Length > 50)
            {
                check = false;
            }
            else
            {
                check = true;
            }
            return check;
        }
    
        private bool PasswordCheck()
        {
            bool check;
            if (Password != Password1)
            {
                check = false;
            }
            else
            {
                check = true;
            }
            return check;
        }
     
        private bool PasswordCheckCount()
        {
            bool check;
            if (Password.Length > 5 || Password.Length < 21)
            {
                check = true;
            }
            else
            {
                check = false;
            }
            return check;
        }
      
        private bool IDCardCheckCount()
        {
            bool check;
            if (IdCard.Length < 12 || IdCard.Length > 14)
            {
                check = false;
            }
            else
            {
                check = true;
            }
            return check;
        }
    
        private bool AddressCheckCount()
        {
            bool check;
            if (Address.Length > 301)
            {
                check = false;
            }
            else
            {
                check = true;
            }
            return check;
        }
      
        private bool DoubleDataEmailCheck()
        {
            PickEmail();
            bool check;
            if (Email == emailFromPick)
            {
                check = false;
            }
            else
            {
                check = true;
            }
            return check;
        }
        private void PickEmail()
        {
            using (SqliteConnection dataBase = new SqliteConnection("Filename=StaffsData.db"))
            {
                dataBase.Open();
                SqliteCommand commandEmail = new SqliteCommand();
                commandEmail.Connection = dataBase;
                commandEmail.CommandText = "SELECT Email from StaffTable WHERE Email='" + Email + "'";

                SqliteDataReader sqliteDataReader = commandEmail.ExecuteReader();

                while (sqliteDataReader.Read())
                {
                    emailFromPick = sqliteDataReader.GetString(0);
                }
                dataBase.Close();
            }

        }
    }
}
