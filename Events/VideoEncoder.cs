using System;
using System.Threading;

namespace Events
{
    public class VideoEnventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
    public class VideoEncoder
    {
        //public delegate void VideoEncodeEventHandler(object source, VideoEnventArgs args);
        //public event VideoEncodeEventHandler VideoEncoded;
        public event EventHandler<VideoEnventArgs> VideoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEnventArgs() { Video=video});
        }

    }
}
