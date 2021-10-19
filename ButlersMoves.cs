using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Discord;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using Discord.Commands;
using Discord.Webhook;
using Discord.WebSocket;



namespace Gamers_Hub_Butler__Code.Buttlers_Commands
{
    public class ButlersMoves : ModuleBase<SocketCommandContext>
    {
        [Command("hi")]
        public async Task hi()
        {
            await ReplyAsync("Good day masters, i am currently underdevelopment with new features to be released " +
                 "please allow this lonely peasant to be able to see to your needs");
        }
        [Command("help")]
        public async Task help()
        {
            await ReplyAsync("my commands are comic, hi, status, wallpaper, ping");
        }


        [Command("comic")]
        public async Task comic(params string [] args)
        {
            
            //collect user input 
            
            await ReplyAsync("sorry due to my master being lazy as fuck i have been programmed to send the comic page by page " +
                 "heres what we have in store " +
                 " **Dceased dead planet from #3** "+
                 "reply with  numbers only please dont break me");
                        
            if (args.Length == 0 || !int.TryParse(args[0], out int comicNumber))
            {
            
                await ReplyAsync("You have to enter a number!");
                return;
            }
            
            if (comicNumber==3)
            {
                await Context.Channel.SendFileAsync(@"C:\Users\obi\Desktop\dccomics\dceased dead planet\Dceased3\dceased3-1.jpg" , "here you go");
                await Context.Channel.SendFileAsync(@"C:\Users\obi\Desktop\dccomics\dceased dead planet\Dceased3\dceased3-2.jpg");
                await Context.Channel.SendFileAsync(@"C:\Users\obi\Desktop\dccomics\dceased dead planet\Dceased3\dceased3-3.jpg");
                await Context.Channel.SendFileAsync(@"C:\Users\obi\Desktop\dccomics\dceased dead planet\Dceased3\dceased3-4.jpg");
                await Context.Channel.SendFileAsync(@"C:\Users\obi\Desktop\dccomics\dceased dead planet\Dceased3\dceased3-5.jpg");
                await Context.Channel.SendFileAsync(@"C:\Users\obi\Desktop\dccomics\dceased dead planet\Dceased3\dceased3-6.jpg");
                await Context.Channel.SendFileAsync(@"C:\Users\obi\Desktop\dccomics\dceased dead planet\Dceased3\dceased3-7.jpg" );
                await Context.Channel.SendFileAsync(@"C:\Users\obi\Desktop\dccomics\dceased dead planet\Dceased3\dceased3-8.jpg");
                await Context.Channel.SendFileAsync(@"C:\Users\obi\Desktop\dccomics\dceased dead planet\Dceased3\dceased3-9.jpg");
                await Context.Channel.SendFileAsync(@"C:\Users\obi\Desktop\dccomics\dceased dead planet\Dceased3\dceased3-10.jpg");
                await Context.Channel.SendFileAsync(@"C:\Users\obi\Desktop\dccomics\dceased dead planet\Dceased3\dceased3-11.jpg");
                await Context.Channel.SendFileAsync(@"C:\Users\obi\Desktop\dccomics\dceased dead planet\Dceased3\dceased3-12.jpg");
                await Context.Channel.SendFileAsync(@"C:\Users\obi\Desktop\dccomics\dceased dead planet\Dceased3\dceased3-13.jpg");
                await Context.Channel.SendFileAsync(@"C:\Users\obi\Desktop\dccomics\dceased dead planet\Dceased3\dceased3-14.jpg");
                await Context.Channel.SendFileAsync(@"C:\Users\obi\Desktop\dccomics\dceased dead planet\Dceased3\dceased3-15.jpg");
                await Context.Channel.SendFileAsync(@"C:\Users\obi\Desktop\dccomics\dceased dead planet\Dceased3\dceased3-16.jpg");
                await Context.Channel.SendFileAsync(@"C:\Users\obi\Desktop\dccomics\dceased dead planet\Dceased3\dceased3-17.jpg");
                await Context.Channel.SendFileAsync(@"C:\Users\obi\Desktop\dccomics\dceased dead planet\Dceased3\dceased3-18.jpg");
                await Context.Channel.SendFileAsync(@"C:\Users\obi\Desktop\dccomics\dceased dead planet\Dceased3\dceased3-19.jpg");
                await Context.Channel.SendFileAsync(@"C:\Users\obi\Desktop\dccomics\dceased dead planet\Dceased3\dceased3-20.jpg");
                await Context.Channel.SendFileAsync(@"C:\Users\obi\Desktop\dccomics\dceased dead planet\Dceased3\dceased3-21.jpg");
                await Context.Channel.SendFileAsync(@"C:\Users\obi\Desktop\dccomics\dceased dead planet\Dceased3\dceased3-22.jpg");
                await Context.Channel.SendFileAsync(@"C:\Users\obi\Desktop\dccomics\dceased dead planet\Dceased3\dceased3-23.jpg");


            }

        }

        [Command("status")]
        public async Task status()
        {
            await Context.Client.SetGameAsync("Butler /GH");
            await Task.CompletedTask;
        }

        [Command("wallpaper")]

        public async Task wallpaper()
        {
            await Context.Channel.SendFileAsync(@"C:\Users\obi\Downloads\cum.jpg"  , "here you go");



        }

        [Command("ping")]       
        public async Task ping()
        {
            await ReplyAsync("pong\n " +
                "hello master type butler help for more information");
        }
        
                                                                                  
    }

}
