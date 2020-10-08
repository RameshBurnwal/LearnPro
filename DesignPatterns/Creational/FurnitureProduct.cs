using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace DesignPatterns.Creational
{
    public class FurnitureProduct
    {
        private Furniture _FurnitureFactory { get; set; }
        public FurnitureProduct(Furniture furniture)
        {
            this._FurnitureFactory = furniture;
        }
        public BaseFurniture GetFurniture(string sofa)
        {
            BaseFurniture furniture = _FurnitureFactory.GetFurniture(sofa);
            return furniture;

        }
    }

    public class client
    {
       public void GetFurnitureProduct()
        {
            var product = new FurnitureProduct(new RoyalFurnitureFactory()).GetFurniture("sofa");
            Sofa ss = (Sofa)product;
            string st = ss.Name;
        }
    }

   
}
