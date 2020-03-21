using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Login_Page_With_Json
{
    public class Mainframe
    {

        // Default folder    
        static readonly string textFile = @"D:\C#\VS\not sure at this point\usernames.txt";
        public static int attempts = 0;
        public static bool loginSuccess = false;
        public static string username;
        public static string password;
        public static string newUser;
        public static string newPass;
        public static int correct = 0;
        public static int index;
        public static List<string> loginMenu = new List<string> { "Login", "Register", "Quit" };
        public static List<string> usernames = new List<string> { };
        public static List<string> passwords = new List<string> { };

        public static void CentreText(String text)
        {
            Console.Write(new string(' ', (Console.WindowWidth - text.Length) / 2));
            Console.WriteLine(text);
        }
        private static void Welcome()
        {
            Console.Clear();
            Console.Title = ("Logged in as " + username);
            CentreText(" ------------------- Welcome --------------------");
            Console.ReadKey();
        }
        private static string DrawMenu(IList<string> menus)
        {
            do
            {
                Console.Clear();
                for (var i = 0; i < menus.Count; i++)
                {
                    if (i == index)
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine(menus[i]);
                    }
                    else
                    {
                        Console.WriteLine(menus[i]);
                    }

                    Console.ResetColor();
                }

                var keyMenu = Console.ReadKey();

                switch (keyMenu.Key)
                {
                    case ConsoleKey.DownArrow when index == menus.Count - 1:
                        index = 0; //Remove the comment to return to the topmost item in the list
                        break;
                    case ConsoleKey.DownArrow:
                        index++;
                        break;
                    case ConsoleKey.UpArrow when index <= 0:
                        index = menus.Count - 1; //Remove the comment to return to the item in the bottom of the list
                        break;
                    case ConsoleKey.UpArrow:
                        index--;
                        break;
                    case ConsoleKey.Enter:
                        return menus[index];
                }

                Console.Clear();
                return "";
            } while (correct == 0);
        }
        public static void SlowPrint(String text)
        {
            foreach (char d in text)
            {
                Thread.Sleep(20);
                Console.Write(d);
            }
        }
        public static void Login()
        {
            while (attempts != 3)
            {
                Console.Clear();
                SlowPrint("Username: ");
                username = Console.ReadLine();
                SlowPrint("Password: ");
                string pass = "";
                do
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    // Backspace Should Not Work
                    if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                    {
                        pass += key.KeyChar;
                        Console.Write("*");
                    }
                    else
                    {
                        if (key.Key == ConsoleKey.Backspace && pass.Length > 0)
                        {
                            pass = pass.Substring(0, (pass.Length - 1));
                            Console.Write("\b \b");
                        }
                        else if (key.Key == ConsoleKey.Enter)
                        {
                            Console.WriteLine("");
                            break;
                        }
                    }
                } while (true);
                foreach (var item in DataFinder._data)
                {
                    if (item.username == username && item.password == pass)
                    {
                        loginSuccess = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Username or password is incorrect");
                        Console.ReadKey();
                        attempts++;
                        break;
                    }
                }
                if (loginSuccess == true)
                {
                    break;
                }
            }
            if (loginSuccess == true)
            {
                Welcome();
            }
            if (attempts == 3)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.WindowHeight = 20;
                Console.WindowWidth = 135;
                Console.SetBufferSize(135, 20);
                Console.CursorVisible = false;
                var s = "\n" +
"\t ██████╗██╗   ██╗ ██████╗████████╗███████╗███╗   ███╗   ██████╗███████╗ █████╗ ██╗   ██╗██████╗ ██╗████████╗██╗   ██╗\n" +
"\t██╔════╝╚██╗ ██╔╝██╔════╝╚══██╔══╝██╔════╝████╗ ████║  ██╔════╝██╔════╝██╔══██╗██║   ██║██╔══██╗██║╚══██╔══╝╚██╗ ██╔╝\n" +
"\t╚█████╗  ╚████╔╝ ╚█████╗    ██║   █████╗  ██╔████╔██║  ╚█████╗ █████╗  ██║  ╚═╝██║   ██║██████╔╝██║   ██║    ╚████╔╝ \n" +
"\t ╚═══██╗  ╚██╔╝   ╚═══██╗   ██║   ██╔══╝  ██║╚██╔╝██║   ╚═══██╗██╔══╝  ██║  ██╗██║   ██║██╔══██╗██║   ██║     ╚██╔╝  \n" +
"\t██████╔╝   ██║   ██████╔╝   ██║   ███████╗██║ ╚═╝ ██║  ██████╔╝███████╗╚█████╔╝╚██████╔╝██║  ██║██║   ██║      ██║  \n" +
"\t╚═════╝    ╚═╝   ╚═════╝    ╚═╝   ╚══════╝╚═╝     ╚═╝  ╚═════╝ ╚══════╝ ╚════╝  ╚═════╝ ╚═╝  ╚═╝╚═╝   ╚═╝      ╚═╝  \n" +
"\n" +
"\t   █████╗ ██╗     ███████╗██████╗ ████████╗ ██╗  ██╗███╗  ██╗████████╗██████╗ ██╗   ██╗██████╗ ███████╗██████╗ \n" +
"\t  ██╔══██╗██║     ██╔════╝██╔══██╗╚══██╔══╝ ╚═╝  ██║████╗ ██║╚══██╔══╝██╔══██╗██║   ██║██╔══██╗██╔════╝██╔══██╗\n" +
"\t  ███████║██║     █████╗  ██████╔╝   ██║         ██║██╔██╗██║   ██║   ██████╔╝██║   ██║██║  ██║█████╗  ██████╔╝\n" +
"\t  ██╔══██║██║     ██╔══╝  ██╔══██╗   ██║         ██║██║╚████║   ██║   ██╔══██╗██║   ██║██║  ██║██╔══╝  ██╔══██╗\n" +
"\t  ██║  ██║███████╗███████╗██║  ██║   ██║    ██╗  ██║██║ ╚███║   ██║   ██║  ██║╚██████╔╝██████╔╝███████╗██║  ██║\n" +
"\t  ╚═╝  ╚═╝╚══════╝╚══════╝╚═╝  ╚═╝   ╚═╝    ╚═╝  ╚═╝╚═╝  ╚══╝   ╚═╝   ╚═╝  ╚═╝ ╚═════╝ ╚═════╝ ╚══════╝╚═╝  ╚═╝\n";
                Console.WriteLine(String.Format("{0," + (Console.WindowWidth / 2 + s.Length / 2) + "}", s));
                Thread.Sleep(2000);
            }
        }
        
        public static void Main1()
        {
            Console.Title = "Mainframe";
            Console.WindowHeight = 20;
            Console.WindowWidth = 80;
            Console.SetBufferSize(80, 20);
            Console.CursorVisible = false;
            correct = 0;
            do
            {
                try
                {
                    var selectedDifficulty = DrawMenu(loginMenu);
                    if (selectedDifficulty == loginMenu[0])
                    {
                        Login();
                        correct = 1;
                    }
                    else if (selectedDifficulty == loginMenu[1])
                    {
                        Register.Registration();
                        correct = 1;
                    }
                    else if (selectedDifficulty == loginMenu[2])
                    {
                        SlowPrint("Exiting...");
                        Thread.Sleep(400);
                        Environment.Exit(0);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                }
            } while (correct == 0);
            Console.Clear();
            correct = 0;
        }

    }
}
