using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class UserClass
    {
        public string firstName;
        public string lastName; 
        public string age;
        public string phone;
        public string email;

        /// <summary>
        /// public method for setting user information in UserForm
        /// </summary>
        /// <param name="fName"></param>
        /// <param name="lName"></param>
        /// <param name="uAge"></param>
        /// <param name="uPhone"></param>
        /// <param name="uEmail"></param>
        public void setUserInfo(string fName, string lName, string uAge, string uPhone, string uEmail)
        {
            firstName = fName;
            lastName = lName;
            age = uAge;
            phone = uPhone;
            email = uEmail;
        }

        /// <summary>
        /// Resets all user information with reflects on UserForm
        /// </summary>
        public void resetUserInfo()
        {
            firstName = "";
            lastName = "";
            age = "";
            phone = "";
            email = "";
        }

        /// <summary>
        /// Returns last name for ScoreForm
        /// </summary>
        /// <returns></returns>
        public string getUserName()
        {
            return lastName;
        }
    }
}