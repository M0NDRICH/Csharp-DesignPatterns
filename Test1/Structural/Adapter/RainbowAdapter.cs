using DesignPatterns.Structural.Adapter.Package;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Adapter
{
    public class RainbowAdapter : Rainbow, IColor
    {
        public void Apply(Video video)
        {
            Setup();
            Update(video);
        }
    }
}
