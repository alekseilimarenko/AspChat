using System;

namespace AspChat.Models
{
    public class Message
    {
        //Message Id
        public Guid Id { get; set; }

        //UserLogin
        public string Sender { get; set; }

        //Message
        public string ChatMessage { get; set; }

        //Message DateTime
        public DateTime Date { get; set; }
    }
}