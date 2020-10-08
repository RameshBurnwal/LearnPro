using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RameshWorkBook.DAL.Entity
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double MRP { get; set; }
        public double OrgPrice { get; set; }
    }
}
