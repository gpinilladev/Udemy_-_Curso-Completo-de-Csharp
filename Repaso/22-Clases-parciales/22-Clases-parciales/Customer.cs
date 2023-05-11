using System;
namespace _22_Clases_parciales
{
    partial class CustomerNoStatic
    {

        private string emailCustomer { get; set; }


        public CustomerNoStatic()
        {
        }

        public string getEmailCustomer(string email)
        {
            return "Email customer : " + email;
        }


    }
}