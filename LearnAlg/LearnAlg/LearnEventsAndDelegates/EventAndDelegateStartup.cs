using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAlg.LearnEventsAndDelegates
{
    internal class EventAndDelegateStartup
    {
        public static void Execute()
        {
             Video video = new Video() { Title = "Video 1" };
            VideoEncoder encoder = new VideoEncoder(); // publisher
            var mailService = new MailService(); // Subscriber
            var messageService = new MessageService(); // Subscriber
            encoder.VideoEncoded += mailService.OnVideoEncoded;
            encoder.VideoEncoded += messageService.OnVideoEncoded;
            encoder.Encode(video);
        }
    }
}
