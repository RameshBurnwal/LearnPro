using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RameshWorkBook.DAL.Entity
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public bool IsActive { get; set; }
        public List<Product> Products { get; set; }
    }
}
