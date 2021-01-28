using System;
using System.Net.Mail;

namespace BlabberApp.Domain
{
    public class User
    {
        private string _ID;

        public User setID(string newID)
        {
            try
            {
                MailAddress m =  new MailAddress(newID); // validation only
            }
            catch (FormatException fe)
            {
                throw new FormatException(fe.ToString());
            }

            _ID = newID;
            return this;
        }
        public string getID()
        {
            return _ID;
        }
    }
}
