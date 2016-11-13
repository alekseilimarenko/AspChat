using AspChat.Models;

namespace AspChat.Utils
{
    public class UtilsUser
    {
        public static void UpdateUserByModelFromWeb(ChatContext context, ref User user)
        {
            if (!user.Id.Equals(null))
            {
                context.Users.Add(user);
            }

            context.SaveChanges();
        }

        public static void UpdateMsgFromWeb(ChatContext context, ref Message msg)
        {
            if (!msg.Id.Equals(null))
            {
                context.Messages.Add(msg);
            }

            context.SaveChanges();
        }
    }
}