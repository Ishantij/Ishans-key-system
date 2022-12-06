using System;
using System.Net;
namespace Keysystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //enter the pastebin link which will contain the current key
            string keylinked1 = "https://pastebin.com/raw/T4ahPkCy"; //pastebin link which will contain the link to the key
            string keylinked2 = "https://pastebin.com/raw/T4ahPkCy";
            string keylinked3 = "https://pastebin.com/raw/T4ahPkCy";
            string keylinked4 = "https://pastebin.com/raw/T4ahPkCy";
            string getkey1 = "linkvertise link";
            string getkey2 = "linkvertise link";
            string getkey3 = "linkvertise link";
            string getkey4 = "linkvertise link";



            //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            int max = 4; //change 4 to how many key systems you have, if you change 4 you also need to multiply the keysystems
            Random rnd = new Random();
            int nmbr = rnd.Next(1, max);





         












            DateTime thisDay = DateTime.Today;
    
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Voyager Key System");
            Console.ForegroundColor= ConsoleColor.Cyan;
            string MachineName2 = Dns.GetHostName();
            WebClient client = new WebClient();
            //randomizing which key to go through
            //----------------------------------------------------------------
            Console.WriteLine("delete save? DEBUGGING"); //testing the system delete this part if you want to implement it into your exploit!
           string y = Console.ReadLine();
            if (y == "yes")
            {
                Properties.Settings.Default.keysaved = "";
                Properties.Settings.Default.Save(); // Saves settings in application configuration file
            };
          //--------------------------------------------------------------------

            if (Properties.Settings.Default.keysaved == thisDay.ToString("d"))
            {
                Console.WriteLine("key already entered");
                client.Dispose();
            }
            else
            {

                if (nmbr == 1)
                {
                    // gets latest keylink
                    string keylink = client.DownloadString(keylinked1);
                    // downloads key
                    string keycheck = client.DownloadString(keylink);


                    Console.WriteLine("Hello " + MachineName2 + "! Please Enter Your Key! ");
                    Console.WriteLine("You can get the key at " + getkey1);
                    Console.ForegroundColor = ConsoleColor.White;

                    string userkeyinput = Console.ReadLine();
                    if (keycheck.Equals(userkeyinput))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You Have Passed The KeySytem");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Properties.Settings.Default.keysaved = thisDay.ToString("d");
                        Properties.Settings.Default.Save(); // Saves settings in application configuration file
                        client.Dispose();

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You Have Failed The KeySytem");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        client.Dispose();
                    }


                }
                if (nmbr == 2)
                {
                    // gets latest keylink
                    string keylink1 = client.DownloadString(keylinked2);
                    // downloads key
                    string keycheck1 = client.DownloadString(keylink1);


                    Console.WriteLine("Hello " + MachineName2 + "! Please Enter Your Key! ");
                    Console.WriteLine("You can get the key at " + getkey2);
                    string userkeyinput1 = Console.ReadLine();
                    if (keycheck1.Equals(userkeyinput1))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You Have Passed The KeySytem");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Properties.Settings.Default.keysaved = thisDay.ToString("d");
                        Properties.Settings.Default.Save(); // Saves settings in application configuration file
                        client.Dispose();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You Have Failed The KeySytem");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        client.Dispose();
                    }


                }
                if (nmbr == 3)
                {
                    // gets latest keylink
                    string keylink2 = client.DownloadString(keylinked3);
                    // downloads key
                    string keycheck2 = client.DownloadString(keylink2);


                    Console.WriteLine("Hello " + MachineName2 + "! Please Enter Your Key! ");
                    Console.WriteLine("You can get the key at " + getkey3);
                    string userkeyinput2 = Console.ReadLine();
                    if (keycheck2.Equals(userkeyinput2))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You Have Passed The KeySytem");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Properties.Settings.Default.keysaved = thisDay.ToString("d");
                        Properties.Settings.Default.Save(); // Saves settings in application configuration file
                        client.Dispose();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You Have Failed The KeySytem");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        client.Dispose();
                    }
                    if (nmbr == 4)
                    {
                        // gets latest keylink
                        string keylink3 = client.DownloadString(keylinked4);
                        // downloads key
                        string keycheck3 = client.DownloadString(keylink3);


                        Console.WriteLine("Hello " + MachineName2 + "! Please Enter Your Key! ");
                        Console.WriteLine("You can get the key at " + getkey4);
                        string userkeyinput3 = Console.ReadLine();
                        if (keycheck3.Equals(userkeyinput3))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You Have Passed The KeySytem");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Properties.Settings.Default["keysaved"] = thisDay.ToString("d");
                            Properties.Settings.Default.Save(); // Saves settings in application configuration file
                            client.Dispose();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You Have Failed The KeySytem");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            client.Dispose();
                        }


                    }


                }
            }
           









        }
    }
}
