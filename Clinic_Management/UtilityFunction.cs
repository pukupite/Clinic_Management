using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Management
{
    internal class UtilityFunction
    {


        private DataAccess da = new DataAccess();


        public bool IsEmailUnique(string email, int id, string tableName, string columnName)
        {


            string query = $"SELECT 1 FROM {tableName} WHERE Email='{email}' AND {columnName} != {id}";
            DataTable dt = da.ExecuteQueryTable(query);

          
            return dt.Rows.Count == 0;
        }





        // ================= NAME =================
        public bool NameValidation(string name)
        {
            if (name == "")
            {
                MessageBox.Show("Name is required!");
                return false;
            }
            if (!name.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Name must contain only letters and spaces!");
                return false;
            }
            if (name.Length < 3)
            {
                MessageBox.Show("Name must be at least 3 characters!");
                return false;
            }
            if (name.Length > 50)
            {
                MessageBox.Show("Name must be less than 50 characters!");
                return false;
            }
            return true;
        }



        // ================= PHONE =================
        public bool PhoneValidation(string phone)
        {
            if (phone == "")
            {
                MessageBox.Show("Phone number is required!");
                return false;
            }

            if (!phone.All(char.IsDigit))
            {
                MessageBox.Show("Phone must contain only digits!");
                return false;
            }

            if (phone.Length != 11)
            {
                MessageBox.Show("Phone number must be 11 digits!");
                return false;
            }

            if (!(phone.StartsWith("013") ||
                  phone.StartsWith("014") ||
                  phone.StartsWith("015") ||
                  phone.StartsWith("016") ||
                  phone.StartsWith("017") ||
                  phone.StartsWith("018") ||
                  phone.StartsWith("019")))
            {
                MessageBox.Show("Enter a valid Bangladeshi phone number!");
                return false;
            }
            return true;
        }



        // ================= EMAIL =================
        public bool EmailValidation(string email)
        {
            // ================= EMAIL =================
            if (email == "")
            {
                MessageBox.Show("Email is required!");
                return false;
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Enter a valid email address!");
                return false;
            }
            return true;

        }



        // ================= PASSWORD =================
        public bool PasswordValidation(string password)
        {
           
            if (password == "")
            {
                MessageBox.Show("Password is required!");
                return false;
            }
            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters!");
                return false;
            }
            return true;
        }



        // ================= NID =================
        public bool NIDValidation(string NID)
        {
            if (NID == "")
            {
                MessageBox.Show("NID is required!");
                return false;
            }
            if (!NID.All(char.IsDigit))
            {
                MessageBox.Show("NID must contain only digits!");
                return false;
            }
            if (NID.Length != 10 && NID.Length != 13 && NID.Length != 17)
            {
                MessageBox.Show("NID number must be 10, 13, or 17 digits!");
                return false;
            }
            return true;
        }



        // ================= SPECIALIST =================
        public bool SpecialistValidation(string specialist)
        {
            if (specialist == "" )
            {
                MessageBox.Show("Specialist field is required!");
                return false;
            }

            if (specialist.Length < 3)
            {
                MessageBox.Show("Enter a valid specialization!");
                return false;
            }
            return true;
        }








    }
}