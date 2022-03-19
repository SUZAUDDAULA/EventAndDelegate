using System;

namespace Events
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEnventArgs args)
        {
            Console.WriteLine("MessageService: Sending a text message..."+args.Video.Title);
        }
    }
}
