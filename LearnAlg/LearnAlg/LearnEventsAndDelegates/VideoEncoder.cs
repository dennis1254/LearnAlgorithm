using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LearnAlg.LearnEventsAndDelegates
{
    internal class VideoEncoder
    {
        // Define a delegate
        // Define an event based on that delegate
        // Raise the event
        // public delegate void VideoEncodedHandler(object source, VideoEventArg args); // No need to create different event handler delegates as we can use the generic on from .NET
        // public event VideoEncodedHandler VideoEncoded;
        public event EventHandler<VideoEventArg> VideoEncoded;
        public void Encode(Video video)
        {
           
            Console.WriteLine("Encoding video..........");
            Thread.Sleep(3000);
            OnVideoEncoded(video);
        }
        protected virtual void OnVideoEncoded(Video video)
        {
            if(VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArg() { Video = video});
            }
        }
    }
}
