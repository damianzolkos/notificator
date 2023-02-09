using Microsoft.Toolkit.Uwp.Notifications;

namespace Notificator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var notification = new ToastContentBuilder()
                .AddArgument("action", "viewConversation")
                .AddArgument("conversationId", 6969);

            if (args.Length > 0)
            {
                foreach (var arg in args)
                {
                    notification.AddText(arg);
                }
            }
            else
            {
                notification.AddText("Some notification");
            }

            notification.Show();
        }
    }
}