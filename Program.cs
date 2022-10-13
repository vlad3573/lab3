using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\t\t--Pro calculator free--");
            Console.WriteLine("\nTrial version is activated by default");
            Console.WriteLine("\nTo open trial version of a calculator type - 1");
            Console.WriteLine("To use an activasion code for Common and Pro versions type - 2");

            
            switch (Console.ReadLine())
            {
                case "1":
                    ApplicationLicense applicationLicense01 = new ApplicationLicense();
                    applicationLicense01.AllowTrial();
                    break;
                case "2":
                    Console.WriteLine("\nType an activasion code:");
                    Console.WriteLine("Type - *common*, to activate a Common version");
                    Console.WriteLine("Type - *Pro*, to activate a Pro version");
                    
                    switch (Console.ReadLine())
                    {
                        case "common":
                            ApplicationLicense applicationLicense02 = new ApplicationLicense();
                            applicationLicense02.AllowCommon();
                            break;
                        case "Pro":
                            ApplicationLicense aplicationLicense03 = new ApplicationLicense();
                            aplicationLicense03.AllowPro();
                            break;
                        default:
                            Console.WriteLine("**INPUT ERROR**");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("\n**INPUT ERROR**");
                    break;
            }
        }
    }
}
