using System;
namespace AdapterAssignment
{
    public class DBError : IErrorModel
    {
        private int _eroorNumber;
        private String _description;
        public int ErrorNumber
        {
            get
            {
                return _eroorNumber;
            }
            set
            {
                _eroorNumber = value;
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
            Console.WriteLine("{0} {1} -> Database Hatası Gönderildi.", _eroorNumber.ToString(), Description);
        }
    }
}
