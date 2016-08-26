using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;

namespace ConsoleApplication1
{
    class Bot
    {
        private DiscordClient bot;

        public void DiscoBot()
        {
            bot = new DiscordClient();


            bot.MessageReceived += Bot_MessageReceived;

            bot.ExecuteAndWait(async() =>
            {
                await bot.Connect("", "");
            });
        }

        private static void Bot_MessageReceived(object sender, MessageEventArgs e)
        {
            Console.WriteLine("{0} said {1}", e.User.Name, e.Message.Text);

            switch (e.Message.Text)
            {
                case "!rules":
                    break;
                case "who is discobot":
                    break;
                default:
                    break;
            }
        }
    }
}
