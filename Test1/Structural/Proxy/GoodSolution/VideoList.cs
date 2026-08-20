using DesignPatterns.Structural.Proxy.GoodSolution.Package;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Proxy.GoodSolution
{
    public class VideoList
    {
        private Dictionary<string, IVideo> _videoList = new();

        public void Add(IVideo video)
        {
            _videoList.Add(video.GetVideoId()!, video);
        }

        public void Watch(string videoId)
        {
            var video = _videoList[videoId];
            video.Render();
        }
    }
}
