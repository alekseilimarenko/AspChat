using System;
using System.ComponentModel.DataAnnotations;

namespace AspChat.Models
{
    public class Message
    {
        //Message Id
        public Guid Id { get; set; }

        //UserLogin
        [Display(Name = "Отправитель")]
        public string Sender { get; set; }

        //Message
        [Display(Name = "Текст сообщения")]
        public string ChatMessage { get; set; }

        //Message DateTime
        [Display(Name = "Дата")]
        public DateTime Date { get; set; }
    }
}