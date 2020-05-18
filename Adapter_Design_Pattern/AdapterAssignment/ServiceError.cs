using System;
namespace AdapterAssignment
{
    public class ServiceError : IErrorModel
    {
        private int _errorNumber;
        private string _description;
        public int ErrorNumber
        {
            get
            {
                return _errorNumber;
            }
            set
            {
                _errorNumber = value;
            }
        }
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }


        public void SendMail()
        {
            Console.WriteLine("{0} {1} Servis hatası gönderildi.", _errorNumber.ToString(), Description);
        }
    }
}
