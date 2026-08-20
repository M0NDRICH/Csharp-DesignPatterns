using DesignPatterns.Structural.Proxy.GoodSolution.Package;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Proxy.GoodSolution
{
    public class YouTubeVideoProxy : IVideo
    {
        private string? _videoId;
        private YouTubeVideo _youtubeVideo;
        public YouTubeVideoProxy(string? videoId)
        {
            _videoId = videoId;
        }
        public string? GetVideoId()
        {
            return _videoId;
        }

        public void Render()
        {
            if (_youtubeVideo == null) 
                _youtubeVideo = new(_videoId!);

            _youtubeVideo.Render();
        }
    }
}
