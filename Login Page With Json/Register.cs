using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Page_With_Json
{
    class Register
    {
        public static void Registration()
        {
            Console.Clear();
            Mainframe.SlowPrint("Enter the sacred texts: ");
            ConsoleKeyInfo ckey = Console.ReadKey();

            if (ckey.Key == ConsoleKey.UpArrow)
            {
                Console.Clear();
                Console.Write("Enter the sacred texts: ");
                ckey = Console.ReadKey();
                if (ckey.Key == ConsoleKey.UpArrow)
                {
                    Console.Clear();
                    Console.Write("Enter the sacred texts: ");
                    ckey = Console.ReadKey();
                    if (ckey.Key == ConsoleKey.DownArrow)
                    {
                        Console.Clear();
                        Console.Write("Enter the sacred texts: ");
                        ckey = Console.ReadKey();
                        if (ckey.Key == ConsoleKey.DownArrow)
                        {
                            Console.Clear();
                            Console.Write("Enter the sacred texts: ");
                            ckey = Console.ReadKey();
                            if (ckey.Key == ConsoleKey.LeftArrow)
                            {
                                Console.Clear();
                                Console.Write("Enter the sacred texts: ");
                                ckey = Console.ReadKey();
                                if (ckey.Key == ConsoleKey.RightArrow)
                                {
                                    Console.Clear();
                                    Console.Write("Enter the sacred texts: ");
                                    ckey = Console.ReadKey();
                                    if (ckey.Key == ConsoleKey.LeftArrow)
                                    {
                                        Console.Clear();
                                        Console.Write("Enter the sacred texts: ");
                                        ckey = Console.ReadKey();
                                        if (ckey.Key == ConsoleKey.RightArrow)
                                        {
                                            Console.Clear();
                                            Console.Write("Enter the sacred texts: ");
                                            ckey = Console.ReadKey();
                                            if (ckey.Key == ConsoleKey.B)
                                            {
                                                Console.Clear();
                                                Console.Write("Enter the sacred texts: ");
                                                ckey = Console.ReadKey();
                                                if (ckey.Key == ConsoleKey.A)
                                                {
                                                    Console.Clear();
                                                    while (true)
                                                    {
                                                        Mainframe.SlowPrint("New username: ");
                                                        Mainframe.newUser = Console.ReadLine();
                                                        Console.Clear();
                                                        Mainframe.SlowPrint("Confirm username: ");
                                                        string newUser1 = Console.ReadLine();
                                                        Console.Clear();
                                                        if (Mainframe.newUser == newUser1)
                                                        {
                                                            Mainframe.SlowPrint("New password: ");
                                                            Mainframe.newPass = Console.ReadLine();
                                                            Console.Clear();
                                                            Mainframe.SlowPrint("Confirm password: ");
                                                            string newPass1 = Console.ReadLine();
                                                            Console.Clear();
                                                            Random random = new Random();
                                                            int randomID = random.Next(100000, 999999);
                                                            if (Mainframe.newPass == newPass1)
                                                            {
                                                                Data employee = new Data
                                                                {
                                                                    Id = 0,
                                                                    username = null,
                                                                    password = null
                                                                };
                                                                var filePath = @"D:\C#\VS\Login Page With Json\passwords.json";
                                                                var jsonData = File.ReadAllText(filePath);
                                                                var users = JsonConvert.DeserializeObject<List<Data>>(jsonData) ?? new List<Data>();

                                                                users.Add(new Data()
                                                                {
                                                                    Id = randomID,
                                                                    username = Mainframe.newUser,
                                                                    password = Mainframe.newPass
                                                                });

                                                                jsonData = JsonConvert.SerializeObject(users);
                                                                File.WriteAllText(filePath, jsonData);
                                                                break;
                                                            }
                                                        }
                                                    }
                                                    Console.WriteLine("Complete");
                                                    Mainframe.Main1();
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Absolute donkey");
                                                    Console.ReadKey();
                                                }
                                            }
                                            else
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Absolute donkey");
                                                Console.ReadKey();
                                            }
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Absolute donkey");
                                            Console.ReadKey();
                                        }
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Absolute donkey");
                                        Console.ReadKey();
                                    }
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Absolute donkey");
                                    Console.ReadKey();
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Absolute donkey");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Absolute donkey");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Absolute donkey");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Absolute donkey");
                    Console.ReadKey();
                }

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Absolute donkey");
                Console.ReadKey();
            }

        }
    }
}
