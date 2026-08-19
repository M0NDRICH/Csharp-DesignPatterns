using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DesignPatterns.Structural.Adapter
{
    public class VideoEditor
    {
        private Video _video;
        public VideoEditor(Video video)
        {
            _video = video;
        }

        public void ApplyColor(IColor color)
        {
            color.Apply(_video);
        }
    }
}
