using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RameshWorkBook.Delegate
{
    public class DeleteCustomerEventArgs : EventArgs
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DeleteCustomerEventArgs(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
