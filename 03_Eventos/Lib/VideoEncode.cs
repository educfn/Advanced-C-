﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Eventos.Lib
{
    public class VideoEncode
    {
        //public delegate void VideoEncodedHandler(Video video);
        //public event VideoEncodedHandler Encoded;

        public event EventHandler<VideoEventArgs> Encoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Convertendo o video...");
            Thread.Sleep(2000);
            Console.WriteLine("Video convertido!");

            Encoded(this, new VideoEventArgs() { Video = video });
        }
    }

    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
}
