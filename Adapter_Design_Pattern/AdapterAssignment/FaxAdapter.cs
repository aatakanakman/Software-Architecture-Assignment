using System;
namespace AdapterAssignment
{
    public class FaxAdapter : IErrorModel
    {
        private Fax _fax;
        public FaxAdapter(Fax fax)
        {
            _fax = fax;
        }

        public int ErrorNumber
        {
            get
            {
                return _fax.FaxErrorCode;
            }
            set
            {
                _fax.FaxErrorCode = value;
            }
        }
        public string Description
        {
            get
            {
                return _fax.ErrorDescription;
            }
            set
            {
                _fax.ErrorDescription = value;
            }
        }

        public void SendMail()
        {
            Console.WriteLine("{0} {1} Fax'a baglanilamadi.", ErrorNumber.ToString(), Description);
        }
    }
}
