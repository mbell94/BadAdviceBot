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
                await bot.Connect("");
            });
        }

        private void Bot_MessageReceived(object sender, MessageEventArgs e)
        {
            if (e.Message.IsAuthor) return;

            Console.WriteLine("{0} said {1}", e.User.Name, e.Message.Text);

            switch (e.Message.Text.Trim())
            {
                case "!rules":
                    e.Channel.SendMessage("Hello, I am bot.  Do not worry about what I do");
                    break;
                case "who is discobot":
                    e.Channel.SendMessage(e.User.Mention + " Do not worry about who I am.  Just know I am always here. Watching. Waiting.");
                    break;
                default:
                    if (e.Message.Text.IndexOf("/") == 0)
                        findCommand(e.Message.Text.Trim());
                    break;
            }
        }

        private void findCommand(string command)
        {

        }
    }
}
