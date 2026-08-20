using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Flyweight.GoodSolution
{
    // Flyweight class
    /// <summary>
    ///  stores intrinsic or constant state that remains constant throughout the object's life
    /// </summary>
    public class CropIcon
    {
        private readonly CropType _type;
        private readonly byte[] _icon;

        public CropIcon(CropType type, byte[] icon)
        {
            _type = type;
            _icon = icon;
        }

        public CropType GetType()
        {
            return _type;
        }
    }
}
