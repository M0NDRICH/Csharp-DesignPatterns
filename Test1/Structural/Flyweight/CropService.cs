using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Flyweight
{
    public class CropService
    {
        public List<Crop> GetCrops()
        {
            List<Crop> cropList = new();

            // fetch from db
            var carrot = new Crop(1, 2, CropType.Carrot, null);
            var carrot2 = new Crop(1, 5, CropType.Carrot, null);
            var carrot3 = new Crop(1, 6, CropType.Carrot, null);

            cropList.Add(carrot);
            cropList.Add(carrot2);
            cropList.Add(carrot3);

            return cropList;
        }
    }
}
