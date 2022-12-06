using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web;


namespace Keysystem_V2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Atonix Keysystem");
            Console.ForegroundColor= ConsoleColor.DarkGreen;
            WebClient client = new WebClient();
            Random random = new Random();
            int chooser = random.Next(1, 7);
            string MachineName = Dns.GetHostName();
            DateTime thisDay = DateTime.Today;
            //----------------------------------------
            Console.WriteLine("delete save?");//for testing
            string debug = Console.ReadLine();
            if (debug == "yes")
            {
                Properties.Settings.Default.keysaved = "";
                Properties.Settings.Default.Save(); // Saves settings in application configuration file
                Console.WriteLine("deleted");
                
            }



            //----------------------------------------
            if (Properties.Settings.Default.keysaved == thisDay.ToString("d"))
            {
                Console.WriteLine("Key Valid");
                await Task.Delay(TimeSpan.FromSeconds(5));
                return;  
            };


            //key
            string key1 = "https://pastebin.com/raw/JgS0KLj0";
            string key2 = "https://pastebin.com/raw/JgS0KLj0";
            string key3 = "https://pastebin.com/raw/JgS0KLj0";
            string key4 = "https://pastebin.com/raw/JgS0KLj0";
            string key5 = "https://pastebin.com/raw/JgS0KLj0";
            string key6 = "https://pastebin.com/raw/JgS0KLj0";
            string key7 = "https://pastebin.com/raw/JgS0KLj0";

            //linkvertise
            string link1 = "link";
            string link2 = "link";
            string link3 = "link";
            string link4 = "link";
            string link5 = "link";
            string link6 = "link";
            string link7 = "link";

            string value = chooser.ToString();
            string link = "";
            string key = "";
            switch (chooser)
            {
                case 1:
                    key = key1;
                    link = link1;
                    break;
                case 2:
                    key = key2;
                    link = link2;
                    break;
                case 3:
                    key = key3;
                    link = link3;
                    break;
                case 4:
                    key = key4;
                    link = link4;
                    break;
                case 5:
                    key = key5;
                    link = link5;
                    break;
                case 6:
                    key = key6;
                    link = link6;
                    break;
                case 7:
                    key = key7;
                    link = link7;
                    break;
            }


            string kellin = client.DownloadString(key);
            string downloadedkey = client.DownloadString(kellin);
            Console.WriteLine("Welcome " + MachineName + "! Please enter your key!");
            Console.WriteLine("Get Key " + link);
            Console.ForegroundColor= ConsoleColor.White;
            string userkey = Console.ReadLine();
            if (userkey.Equals(downloadedkey))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Success, Opening Atonix!");
                Properties.Settings.Default.keysaved = thisDay.ToString("d");
                Properties.Settings.Default.Save(); // Saves settings in application configuration file
                await Task.Delay(TimeSpan.FromSeconds(5));
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Failed, ReOpen Atonix");
                await Task.Delay(TimeSpan.FromSeconds(5));




            }























        }
    }
}
