using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RameshWorkBook.DAL.Entity
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
