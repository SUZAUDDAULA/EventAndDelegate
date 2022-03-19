using System;
namespace Events
{
    public class MailServiceBase
    {
        public void OnVideoEncoded(object source, VideoEnventArgs e)
        {
            Console.WriteLine("MailService: Sending an email..." + e.Video.Title);
        }
    }
}