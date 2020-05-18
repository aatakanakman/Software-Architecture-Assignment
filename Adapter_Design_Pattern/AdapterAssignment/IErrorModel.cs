using System;
namespace AdapterAssignment
{
    public interface IErrorModel
    {
        int ErrorNumber
        {
            get;
            set;
        }

        string Description
        {
            get;
            set;


        }

        void SendMail();
     
       
    }
}
