using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAlg.LearnEventsAndDelegates
{
    internal class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArg e)
        {
            Console.WriteLine("MailService: Sending an email....."+e.Video.Title);
        }
    }
}
