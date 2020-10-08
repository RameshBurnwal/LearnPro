using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static RameshWorkBook.Delegate.DeleteCustomerEventManager;

namespace RameshWorkBook.Delegate
{
    public class ConsumeDeleteCustomerEvent
    {
        public void Consume()
        {
            DeleteCustomerEventManager eventManager = new DeleteCustomerEventManager();
            eventManager.DeleteCustomer += DeleteCartDetails_DeleteCustomer;
        }

        private void DeleteCartDetails_DeleteCustomer(object sender, DeleteCustomerEventArgs e)
        {
            int id = e.Id;
            string name = e.Name;
            Console.WriteLine($"customer delete having id = {id} and Name = {name}");
        }

    }
}
