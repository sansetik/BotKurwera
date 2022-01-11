using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using TwitchLib.Client;
using TwitchLib.Client.Models;

namespace ConsoleApp7
{
    public class Bot
    {
        TwitchClient client = new TwitchClient();
        ConnectionCredentials credentials = new ConnectionCredentials("setprotected", "SECRET CODE TWITH (свой надо вставить я его удалил)");
        private int Tikuta = 0;


        public Bot()
        {
            client.Initialize(credentials, "juneagain");
            
            client.OnLog += Client_OnLog;
            client.OnJoinedChannel += Client_OnJoinedChannel;
            client.OnChatCommandReceived += Client_OnChatCommandReceived;
            client.OnMessageReceived += Client_OnMessageReceived;
            client.Connect();
           
    }

        private void Client_OnMessageReceived(object? sender, TwitchLib.Client.Events.OnMessageReceivedArgs e)
        {
            this.Tikuta++;

            if (this.Tikuta > 900)
            {
                Random rnd = new Random();
                var result = rnd.Next(0, 36);
                string[] suka = new string[37] {
                    "Не плюй в колодец, пригодится воды напиться",

                    "Не делай неприятностей кому-либо, иначе в будущем сам можешь лишиться поддержки",

                    "Под лежачий камень и вода не течет",

                    "Без труда не выловишь и рыбку из пруда.",

                    "Дело не сдвинется с места, если ничего не предпринимать",

                    "Был бы лес, соловьи прилетят.",

                    "Не беречь поросли, не видать и дерева.",

                    "Кто не сажал дерева, тому не лежать в тени.",

                    "Ласточка весну начинает, соловей кончает.",

                    "Дважды в год лето не бывает.",

                    "Летом не припасешь, зимой не принесешь.",

                    "Не зима знобит, а весна.",

                    "Летом - пыль, зимою снег одолевает.",

                    "Придет осень, за все спросит.",

                    "Что летом родится, то зимой пригодится.",

                    "Соколу лес не диво, волку зима за обычай.",

                    "Застает зимушка в летнем платьице.",

                    "Узок путь зимою, а жидок - весною.",

                    "Не пугай, зима,- весна придет.",

                    "Кто весной не пролежит, весь год будет сыт.",

                    "Летом с удочкой, зимой с сумочкой.",

                    "Одна ласточка не делает весны.",

                    "Около речки колодца не копают.",

                    "Зимой солнце сквозь слезы смеется.",

                    "Сугроб да вьюга - два друга.",

                    "Зима весну пугает, да всё равно тает.",

                    "Вода на лугу - сено в стогу.",

                    "Была бы водица, а сено зародится.",

                    "Как зима не злится, а всё весне покорится.",

                    "Зима без трёх подзимков не живёт.",

                    "В июне первую ягоду в рот кладут, а вторую домой несут.",

                    "Кто земле дает, тому земля втройне отдает",

                    "Земля родная - колыбель золотая",

                    "Не поле кормит, а нива",

                    "Дорогой товар из земли растет",

                    "Кто любит земле кланяться - без добычи не останется",

                    "Не поклонясь до земли, и грибов не поднимешь"
                };
                Console.WriteLine($"=========================={e.ChatMessage.Username}========================");
                client.SendMessage(e.ChatMessage.Channel, $"@{e.ChatMessage.Username} {suka[result]}");
                this.Tikuta = 0;

            }
        }

        private void Client_OnSendReceiveData(object? sender, TwitchLib.Client.Events.OnSendReceiveDataArgs e)
        {
           

        }

        private void Client_OnChatCommandReceived(object? sender, TwitchLib.Client.Events.OnChatCommandReceivedArgs e)
        {



            string[] suka = new string[37] {
                    "Не плюй в колодец, пригодится воды напиться",

                    "Не делай неприятностей кому-либо, иначе в будущем сам можешь лишиться поддержки",

                    "Под лежачий камень и вода не течет",

                    "Без труда не выловишь и рыбку из пруда.",

                    "Дело не сдвинется с места, если ничего не предпринимать",

                    "Был бы лес, соловьи прилетят.",

                    "Не беречь поросли, не видать и дерева.",

                    "Кто не сажал дерева, тому не лежать в тени.",

                    "Ласточка весну начинает, соловей кончает.",

                    "Дважды в год лето не бывает.",

                    "Летом не припасешь, зимой не принесешь.",

                    "Не зима знобит, а весна.",

                    "Летом - пыль, зимою снег одолевает.",

                    "Придет осень, за все спросит.",

                    "Что летом родится, то зимой пригодится.",

                    "Соколу лес не диво, волку зима за обычай.",

                    "Застает зимушка в летнем платьице.",

                    "Узок путь зимою, а жидок - весною.",

                    "Не пугай, зима,- весна придет.",

                    "Кто весной не пролежит, весь год будет сыт.",

                    "Летом с удочкой, зимой с сумочкой.",

                    "Одна ласточка не делает весны.",

                    "Около речки колодца не копают.",

                    "Зимой солнце сквозь слезы смеется.",

                    "Сугроб да вьюга - два друга.",

                    "Зима весну пугает, да всё равно тает.",

                    "Вода на лугу - сено в стогу.",

                    "Была бы водица, а сено зародится.",

                    "Как зима не злится, а всё весне покорится.",

                    "Зима без трёх подзимков не живёт.",

                    "В июне первую ягоду в рот кладут, а вторую домой несут.",

                    "Кто земле дает, тому земля втройне отдает",

                    "Земля родная - колыбель золотая",

                    "Не поле кормит, а нива",

                    "Дорогой товар из земли растет",

                    "Кто любит земле кланяться - без добычи не останется",

                    "Не поклонясь до земли, и грибов не поднимешь"
                    };
               

            switch (e.Command.CommandText)
            {
                case "fight":
                    Random rnd = new Random();
                    var result = rnd.Next(1, 23);
                    Console.WriteLine("ЗАЛУПА");
                    client.SendMessage(e.Command.ChatMessage.Channel, $"@{e.Command.ChatMessage.DisplayName} - Ваша Биба сегодня {result} сантиметров");
                    break;
                case "poslovica":
                    Random aaaa = new Random();
                    var sssdss = aaaa.Next(0, 36);
                    client.SendMessage(e.Command.ChatMessage.Channel, $"@{e.Command.ChatMessage.DisplayName} {suka[sssdss]}");
                    break;
            }
            
        }

        private void Client_OnJoinedChannel(object? sender, TwitchLib.Client.Events.OnJoinedChannelArgs e)
        {
            client.SendMessage(e.Channel, "!poslovica - Узнать свою пословицу на сегодняшний день!");
            this.Tikuta = 0;
        }

        private void Client_OnLog(object? sender, TwitchLib.Client.Events.OnLogArgs e)
        {
            Console.WriteLine(e.Data);
            
        }
    }
}
