using DesignPatterns.Structural.Proxy.BadSolution.Package;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Proxy.BadSolution
{
    public class VideoList
    {
        private Dictionary<string, IVideo> _videoList = new();

        public void Add(IVideo video)
        {
            _videoList.Add(video.GetVideoId(), video);
        }

        public void Watch(string videoId)
        {
            var video = _videoList[videoId];
            video.Render();
        }
    }
}
