using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational
{
    public class TraditionalFurnitureFactory : Furniture
    {
        public override BaseFurniture GetFurniture(string type)
        {
            switch (type)
            {
                case "sofa": return new Sofa();

                case "bed": return new Bed();

                default: return new Bed();

            }
        }
    }
}
