using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NDesk.Options;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            string PROGRAM_NAME = "\"Hello, world!\" program";
            string VERSION = "1.0";

            bool version_show = false;
            bool help_show = false;

            string help_message = $"\n" +
                $"{PROGRAM_NAME} v{VERSION}\n" +
                $"\n" +
                $" -t <Text>, --text=<Text>: Other output text. Default value is 'Hello, world!'. The output will be like '<Text>'.\n" +
                $" -g <Text>, --greeting=<Text>: Other greeting text. Default value is 'Hello'. The output will be like '<Greeting>, <Name>!'.\n" +
                $" -n <Text>, --name=<Text>: The name of someone to greet. The default value is 'world'. The output will be like '<Greeting>, <Name>!'.\n" +
                $" -r <Number>, --repeat=<Numver>: The number of times to repeat the greeting. The default value is 1.\n" +
                $" -v, --version: Print the version number and licensing information of Hello on standard output and then exit successfully.\n" +
                $" -h, --help: Print an informative help message on standard output and exit successfully.\n";

            string version_message = $"\n" +
                $"{PROGRAM_NAME} v{VERSION}\n" +
                $"\n" +
                $"Copyright 2022 Kyumin Nam\n" +
                $"\n" +
                $"Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files(the \"Software\"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/ or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:\n" +
                $"\n" +
                $"The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.\n" +
                $"\n" +
                $"THE SOFTWARE IS PROVIDED \"AS IS\", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.\n";

            string text = "Hello, world!";
            string name = "world";
            string greeting = "Hello";
            int repeat = 1;

            var opt = new OptionSet() {
                { "t|text=", "Other output text. Default value is 'Hello, world!'. The output will be like '<Text>'.", (string v) => text = v },
                { "g|greeting=", "Other greeting text. Default value is 'Hello'. The output will be like '<Greeting>, <Name>!'.", (string v) => greeting = v },
                { "n|name=", "The name of someone to greet. The default value is 'world'. The output will be like '<Greeting>, <Name>!'.", (string v) => name = v },
                { "r|repeat=", "The number of times to repeat the greeting. The default value is 1.", (int v) => repeat = v },
                { "v|version",  "Print the version number and licensing information of Hello on standard output and then exit successfully.", v => version_show = true },
                { "h|help",  "Print an informative help message on standard output and exit successfully.", v => help_show = true },
            };

            List<string> extra;
            try
            {
                extra = opt.Parse(args);
            }
            catch (OptionException e)
            {
                Console.Write("Program: ");
                Console.WriteLine(e.Message);
                Console.WriteLine("Try `hello-world.exe --help' for more information.");
                return;
            }

            if (help_show && version_show)
            {
                Console.Write("Program: ");
                Console.WriteLine("You cannot choose these options at same time: (help, version), (text, greeting/name) ");
                Console.WriteLine("Try `hello-world.exe --help' for more information.");
                return;
            }
            else
            {
                if (help_show)
                {
                    Console.WriteLine(help_message);
                    return;
                }
                else if (version_show)
                {
                    Console.WriteLine(version_message);
                    return;
                }
                else
                {
                    ;
                }
            }

            if (text == "Hello, world!") {
                if (greeting == "Hello")
                {
                    if (name == "world")
                    {
                        for (int i = 0; i < repeat; i++)
                        {
                            Console.WriteLine($"Hello, world!");
                        }
                        return;
                    }
                    else
                    {
                        for (int i = 0; i < repeat; i++)
                        {
                            Console.WriteLine($"Hello, {name}!");
                        }
                        return;
                    }
                }
                else
                {
                    if (name == "world")
                    {
                        for (int i = 0; i < repeat; i++)
                        {
                            Console.WriteLine($"{greeting}, world!");
                        }
                        return;
                    }
                    else
                    {
                        for (int i = 0; i < repeat; i++)
                        {
                            Console.WriteLine($"{greeting}, {name}!");
                        }
                        return;
                    }
                }
            } 
            else
            {
                if (greeting != "Hello" || name != "world")
                {
                    Console.Write("Program: ");
                    Console.WriteLine("You cannot choose these options at same time: (help, version), (text, greeting/name) ");
                    Console.WriteLine("Try `hello-world.exe --help' for more information.");
                    return;
                }
                else
                {
                    for (int i = 0; i < repeat; i++)
                    {
                        Console.WriteLine($"{text}");
                    }
                    return;
                }
            }
        }
    }
}
