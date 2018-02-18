using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net;
using System.Threading;
using System.Net.NetworkInformation;
using System.Windows;
using System.Windows.Forms;

namespace easyopenv1
{
    class Program
    {
        static void Main(string[] args)
        {

            WebClient client = new WebClient();
            try
            {
                
                var message = client.DownloadString("");
                Console.WriteLine("Loading Whitelist please wait....");
                System.Threading.Thread.Sleep(5000);
             
                



                    Console.Clear();
                    Console.WriteLine("You are whitelisted!! Loading...");
                    Console.Beep();
                    System.Threading.Thread.Sleep(5000);
                    Console.Clear();
                    Console.WriteLine("Easy Opener v1.0.0.40 :: Welcome to EOv1!");


                    Console.WriteLine("Message of the day! :: " + message);
                    Console.Title = "Easy Opener v1.0.0.40";
                    Console.Write(">");
                    String command;
                    Boolean quitNow = false;
                    while (!quitNow)
                    {
                        command = Console.ReadLine();
                        Console.Write("<");


                        switch (command)
                        {
                            case "help":
                                Console.WriteLine("Commands are; version, quit, website1, cls, beep, load, mario, sw, notepad, gtayt, paint, time, basicyt, updatelog, form1, green, reset, blue, cyan, red, pink, GetInfo.");
                                Console.Write(">");
                                break;

                            case "version":
                                Console.WriteLine("Version v1.0.0.40");
                                Console.Write(">");
                                break;

                            case "quit":
                                quitNow = true;
                                break;
                            case "website1":
                                Process.Start("http://teamnukepvp.com/");
                                Console.Write(">");
                                break;
                            case "credits":
                                Console.WriteLine("Made by bob5918 Whitelist by Bob5918 UI by Bob5918 Upcoming UI made by Basic_Jason/GtaPlayzz EOS = Easy opener scripting made by GtaPlayzz");
                                Console.Write(">");
                                break;
                            case "cls":
                                Console.Clear();
                                Console.Write(">");
                                break;
                            case "beep":
                                Console.Beep();
                                Console.WriteLine("Beep!");
                                Console.Write(">");
                                break;
                            case "load":
                                Console.Clear();
                                Console.Beep();
                                var message2 = "no motd.";
                                Console.WriteLine("Easy Opener v1.0.0.40");
                                Console.WriteLine("Message of the day! :: " + message2);
                                Console.Title = "Easy Opener v1.0.0.40";
                                Console.Write(">");
                                break;


                            case "mario":
                                Console.Beep(659, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(523, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(375); Console.Beep(392, 125); Thread.Sleep(375); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(375); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125); Thread.Sleep(1125); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125);
                                Console.WriteLine("Mario!");
                                Console.Write(">");
                                break;
                            case "sw":
                                Console.Beep(300, 500);
                                Thread.Sleep(50);
                                Console.Beep(300, 500);
                                Thread.Sleep(50);
                                Console.Beep(300, 500);
                                Thread.Sleep(50);

                                Console.Beep(250, 500);
                                Thread.Sleep(50);

                                Console.Beep(350, 250);
                                Console.Beep(300, 500);
                                Thread.Sleep(50);

                                Console.Beep(250, 500);
                                Thread.Sleep(50);

                                Console.Beep(350, 250);
                                Console.Beep(300, 500);
                                Thread.Sleep(50);
                                Console.WriteLine("Star wars!");
                                Console.Write(">");
                                break;

                            case "notepad":
                                Process.Start("notepad.exe");
                                Console.WriteLine("Notepad.exe was launched!");
                                Console.Write(">");
                                break;

                            case "gtayt":
                                Process.Start("https://www.youtube.com/channel/UCXdJg7whRX2nqGk7oIObSxw");
                                Console.WriteLine("This years channel!");
                                Console.Write(">");
                                break;


                            case "paint":
                                Process.Start("mspaint.exe");
                                Console.WriteLine("MSPAINT.EXE HAS BEEN LAUNCHED!");
                                Console.Write(">");
                                break;
                            case "time":
                                Console.WriteLine(DateTime.Now);
                                Console.Write(">");
                                break;
                            case "basicyt":
                                Process.Start("https://www.youtube.com/channel/UCDMlZxgtx4yPN05-itAPD4Q");
                                Console.WriteLine("Basic_Jason YT!");
                                Console.Write(">");
                                break;

                            case "updatelog":
                                var log = "discontinued";
                                Console.WriteLine(log);
                                Console.Write(">");

                                break;

                            case "form1":
                                Application.Run(new eoform2());
                                Console.WriteLine("Mini GUI");
                                Console.Write(">");
                                break;

                            case "stp":
                                Application.Run(new eoform1());
                                Console.WriteLine("Staff GUI");
                                Console.Write(">");
                                break;
                            case "green":
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Green!");
                                Console.Write(">");
                                break;
                            case "reset":
                                Console.ResetColor();
                                Console.WriteLine("Reset color!");
                                Console.Write(">");
                                break;

                            case "blue":
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("Blue!");
                                Console.Write(">");
                                break;

                            case "cyan":
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Cyan!");
                                Console.Write(">");
                                break;
                            case "red":
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Red!");
                                Console.Write(">");
                                break;
                            case "pink":
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("Pink or Magenta!");
                                Console.Write(">");
                                break;

                            case "discord":
                                Console.WriteLine("Discord Code is discord.me/easyopener!");
                                Console.Write(">");
                                break;




                            case "GetInfo":
                                Application.Run(new eoform3());
                                Console.WriteLine("GetInfo GUI by GtaPlayzz and Bob5918!");
                                Console.Write(">");
                                break;


                            case "admin":
                                Console.WriteLine("Hey how did you find this?");
                                Application.Run(new eoform1());
                                Console.Write(">");
                                break;


                            case "HWID":
                                Console.WriteLine("Here is your HWID! " + HWIDGen.Value());
                                Console.Write(">");
                                break;
                            case "c-11":
                                Application.Run(new c_11());
                                Console.WriteLine("c-11 mini os!");
                                Console.Write(">");
                                break;



                            default:
                                Console.WriteLine("Unknown Command " + command);
                                Console.Beep();
                                Console.Write(">");
                                break;

                        

                    }



                }
            }
            catch
            {

                Console.WriteLine("Host is down or you are using a cracked version of EO! LOL");
                Console.Beep();
                System.Threading.Thread.Sleep(10000);
                Environment.Exit(0);



            }

        }
            }
            }
            


      


        

    


