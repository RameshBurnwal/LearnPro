using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace RameshWorkBook.Delegate
{
    public class DeleteCustomerEventManager
    {
        public delegate void DeleteCustomerEventHandler(object sender, DeleteCustomerEventArgs e);
        public event DeleteCustomerEventHandler DeleteCustomer;
        protected virtual void OnDeleteCustomer(DeleteCustomerEventArgs e)
        {
            if(DeleteCustomer != null)
            {
                DeleteCustomer(this, e);
            }
        }   
        
        public void HandleDeleteCustomer(int id, string name)
        {
            DeleteCustomerEventArgs deleteCustomerEventData = new DeleteCustomerEventArgs(id, name);
            OnDeleteCustomer(deleteCustomerEventData);
        }       
    }
}
