using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AspChat.Models
{
    public class MessageDbInitializer : DropCreateDatabaseAlways<ChatContext>
    {
        protected override void Seed(ChatContext db)
        {
            db.Messages.Add(new Message { Id = Guid.NewGuid(), ChatMessage = "Hello Rocket", Sender = "Rocket", Date = Convert.ToDateTime("01/11/2016")});

            db.Messages.Add(new Message { Id = Guid.NewGuid(), ChatMessage = "Hello StarLord", Sender = "StarLord", Date = Convert.ToDateTime("02/11/2016")});

            db.Messages.Add(new Message { Id = Guid.NewGuid(), ChatMessage = "Hello Grut", Sender = "Grut", Date = Convert.ToDateTime("03/11/2016")});

            db.Messages.Add(new Message { Id = Guid.NewGuid(), ChatMessage = "Hello Gamora", Sender = "Gamora", Date = Convert.ToDateTime("04/11/2016")});

            base.Seed(db);
        }
    }
}