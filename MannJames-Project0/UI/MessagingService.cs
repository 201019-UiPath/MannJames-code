using System;
using System.Collections.Generic;
using System.Text;

namespace UI
{
    public class MessagingService: IMessagingService
    {
        public void InvalidInputMessage()
        {
            Console.WriteLine("Invalid input. Please try again.");
        }
    }
}
