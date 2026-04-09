using System;
using System.Media;
using System.Threading;

namespace CYBERBOT_Part_._1
{
    public class CyberBot
    {
        private string userName;

        public void Start()
        {
            Console.Title = "Cybersecurity Awareness Bot";

            ShowHeader();
            PlayVoiceGreeting();
            GetUserName();
            WelcomeUser();
            MenuLoop();
        }

        //================
        //HEADER
        //================
        private void ShowHeader()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("=================================================");
            Console.WriteLine("========CYBERSECURITY AWARENESS BOT==============");
            Console.WriteLine("=================================================");
            Console.WriteLine(@"
      ____      _               ____        _   
     / ___|   _| |__   ___ _ __| __ )  ___ | |_ 
    | |  | | | | '_ \ / _ \ '__|  _ \ / _ \| __|
    | |__| |_| | |_) |  __/ |  | |_) | (_) | |_ 
     \____\__, |_.__/ \___|_|  |____/ \___/ \__|
          |___/                                 
           Stay Safe Online!
");

            Console.ResetColor();

        }
    }
}
