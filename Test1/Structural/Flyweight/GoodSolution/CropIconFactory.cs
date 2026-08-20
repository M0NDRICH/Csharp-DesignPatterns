using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Flyweight.GoodSolution
{
    public class CropIconFactory
    {
        // cache
        private Dictionary<CropType, CropIcon> _icons = new();

        public CropIconFactory()
        {
            
        }

        public CropIcon GetCropIcon(CropType cropType)
        {
            if (!_icons.ContainsKey(cropType))
            {
                var icon = new CropIcon(cropType, null);
                _icons.Add(cropType, icon);
            }

            return _icons[cropType];
        }
    }
}
