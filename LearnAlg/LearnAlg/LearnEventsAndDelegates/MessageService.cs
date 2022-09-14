using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAlg.LearnEventsAndDelegates
{
    internal class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArg e)
        {
            Console.WriteLine("MessageService: Sending an message....."+e.Video.Title);
        }
    }
}
