using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Flyweight.GoodSolution
{
    public class CropService
    {
        private CropIconFactory _iconFactory;
        public CropService(CropIconFactory iconFactory)
        {
            _iconFactory = iconFactory;
        }
        public List<Crop> GetCrops()
        {
            List<Crop> cropList = new();

            //var icon =_iconFactory.GetCropIcon(CropType.Carrot);

            // fetch from db
            var carrot = new Crop(1, 2, _iconFactory.GetCropIcon(CropType.Carrot));
            var carrot2 = new Crop(1, 5, _iconFactory.GetCropIcon(CropType.Carrot));
            var carrot3 = new Crop(1, 6, _iconFactory.GetCropIcon(CropType.Carrot));

            cropList.Add(carrot);
            cropList.Add(carrot2);
            cropList.Add(carrot3);

            return cropList;
        }
    }
}
