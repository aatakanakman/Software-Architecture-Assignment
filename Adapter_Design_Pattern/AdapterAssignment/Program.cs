using System;
using AdapterAssignment;

namespace AdapterDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Fax fax = new Fax { FaxErrorCode = 500, ErrorDescription = "Fax gönderilemedi." };

            IErrorModel[] errors =
            {
                new DBError{ErrorNumber = 200, Description = "Baglanti yok"},
                new DBError{ErrorNumber = 201, Description = "Sorgu yapilamadi."},
                new ServiceError { ErrorNumber = 300 , Description = "Servis yok"},
                new ServiceError { ErrorNumber = 301 , Description = "Yetki Yok"},
                new FaxAdapter(fax)
            };

            foreach (IErrorModel error in errors)
            {
                error.SendMail();
                    
                    
            }

        }
    }
}
