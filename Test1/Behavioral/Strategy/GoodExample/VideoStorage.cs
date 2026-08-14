using DesignPatterns.Behavioral.Strategy.GoodExample;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Strategy.GoodExample
{
    public class VideoStorage
    {
        private ICompressor _compressor;
        private IOverlay _overlay;

        public VideoStorage(ICompressor compressor, IOverlay overlay)
        {
            _compressor = compressor;
            _overlay = overlay ?? new OverlayNone();
        }

        public void SetCompressor(ICompressor compressor)
        {
            _compressor = compressor;
        }
        public void SetOverlay(IOverlay overlay)
        {
            _overlay = overlay;
        }
         
        public void Store(string filename)
        {
            // Compression logic 
            _compressor.Compress();

            // Overlay logic
            _overlay.Apply();

            Console.WriteLine("Storing video to " + filename + _compressor);
        }
    }
}
