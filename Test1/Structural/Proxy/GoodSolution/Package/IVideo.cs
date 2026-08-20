using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Proxy.GoodSolution.Package
{
    public interface IVideo
    {
        void Render();
        string? GetVideoId();
    }
}
