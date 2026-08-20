using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Proxy.GoodSolution.Package
{
    public class YouTubeVideo : IVideo
    {
        private string _videoId;
        public YouTubeVideo(string videoId)
        {
            _videoId = videoId;
            Download();
        }

        private void Download()
        {
            Console.WriteLine("Downloading video with id "+ _videoId + " from YouTube API");
        }

        public void Render()
        {
            Console.WriteLine("Rendering video "+ _videoId);
        }

        public string GetVideoId()
        {
            return _videoId;
        }
    }
}
