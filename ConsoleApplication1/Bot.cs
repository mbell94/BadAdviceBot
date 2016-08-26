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

        public Bot()
        {
            bot = new DiscordClient();

            bot.ExecuteAndWait(async() =>
            {
                bot.MessageReceived += Bot_MessageReceived;

                await bot.Connect("MjE4ODU0MzQyNDY2MjA3NzQ0.CqJPjg.Qbdp9udqeGWv2_Zk7vKsGtPS1l4");
            });
        }

        private void Bot_MessageReceived(object sender, MessageEventArgs e)
        {
            if (e.Message.IsAuthor) return;

            Console.WriteLine("{0} said {1}", e.User.Name, e.Message.Text);

            switch (e.Message.Text)
            {
                case "!rules":
                    e.Channel.SendMessage(e.User.Mention + " You can do it. I believe it you.");
                    
                    break;
                case "who is discobot":
                    e.Channel.SendMessage(e.User.Mention + " You don't need to know who I am. I am always here. Waiting. Watching.");
                    break;
                default:
                    if (e.Message.Text.IndexOf("/") == 0)
                        findCommand(e.Message.Text);
                    break;
            }
        }

        private void findCommand(string command)
        {

        }
    }
}
