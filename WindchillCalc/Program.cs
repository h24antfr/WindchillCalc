using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindchillCalc
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            //Datatyp string med identifierare border, används senare för att printa ut en string i konsollen  
            string border = "-----------------------------------------------------";

            //Datatyp bool med identifierare active, kan vara sann eller falsk
            bool active = true;

            //Metod "while", loop som körs när variablen "active" av datatyp bool är sann
            while (active)
                {   //Metod "Console.Writeline", Printar ut variabeln med identifieraren "border" i konsollen
                Console.WriteLine(border);
                //Metod "Console.Writeline", skriver ut string i konsollen 
                Console.WriteLine("Vad vill du göra (Ange siffra)");
                //Metod "Console.Writeline", skriver ut string i konsollen
                Console.WriteLine("1. Beräkna windchill-faktor");
                //Metod "Console.Writeline", skriver ut string i konsollen
                Console.WriteLine("2. Avsluta");
                //Metod "Console.Write", skriver ut string i konsollen
                Console.Write("Skriv ditt val här: ");
                //Datatyp "string" med identifierare "choice", tar värdet utifrån metoden "Console.ReadLine" Där en string antas från användarens input
                string choice = Console.ReadLine();


                //Metod "switch" med identifieraren "choice"
                switch (choice)
                    {
                    //case "1" körs om strängen "1" angetts och lästs av via metoden "Console.Readline"    
                    case "1":
                        //Datatyp "double" med identifierare "WCT"
                        double WCT;
                        //Datatyp "double" med identifierare "temperature"
                        double temperature;
                        //Datatyp "double" med identifierare "windSpeed"
                        double windSpeed;
                        //Metod "Console.Write", skriver ut string i konsollen
                        Console.WriteLine("Fyll i utomhustemperaturen i Celsius: ");
                        //variabel med identifierare "temperature" och datatyp "double", converterar variabeln till "double" från metoden "Console.Readline" efter användarens input
                        temperature = Convert.ToDouble(Console.ReadLine());
                        //Metod "Console.Write", skriver ut string i konsollen
                        Console.WriteLine("Fyll i vindhastigheten i km/h: ");
                        //variabel med dentifierare "windSpeed" och datatyp "double", converterar variabeln till "double" från metoden "Console.Readline" efter användarens input
                        windSpeed = Convert.ToDouble(Console.ReadLine());
                        //Variablerna med identifierarna "WCT", "temperature" och "windSpeed" sätts in i en formula där de kombinerar med metoden "Math.Pow" och andra beräkningar
                        WCT = 13.12 + 0.6215 * temperature - 11.37 * Math.Pow(windSpeed, 0.16) + 0.3965 * temperature * Math.Pow(windSpeed, 0.16);
                        WCT = Math.Round(WCT, 1);
                        //Metoden "Console.WriteLine", printar ut string och variabeln med identifieraren "WCT" och datatypen "double" i konsollen
                        Console.WriteLine("Windchill temperaturen är " + WCT);
                        //Metoden Thread.Sleep, låter systemet vila i 1000 milisekunder
                        Thread.Sleep(1000);

                        //Metoden "if" kollar om variabeln med identifieraren "WCT" av datatypen "double" är mindre än -60
                        if (WCT < -60)
                            {
                            //Metod "Console.Write", skriver ut string i konsollen
                            Console.WriteLine("Stor risk för frostskada");
                            }
                        //Metoden "else if" kollar om variabeln med identifieraren "WCT" av datatypen "double" är mindre än -35
                        else if (WCT < -35)
                            {
                            //Metod "Console.Writeline", skriver ut string i konsollen    
                            Console.WriteLine("Risk för frostskada");
                            }
                        //Metoden "else if" kollar om variabeln med identifieraren "WCT" av datatypen "double" är mindre än -25
                        else if (WCT < -25)
                            {
                            //Metod "Console.Writeline", skriver ut string i konsollen    
                            Console.WriteLine("Mycket kallt");
                            }
                        //Metoden "else if" kollar om variabeln med identifieraren "WCT" av datatypen "double" är mer än -25
                        else if (WCT > -25)
                            {
                            //Metod "Console.Writeline", skriver ut string i konsollen    
                            Console.WriteLine("Kallt");
                            }
                        //Metoden Thread.Sleep, låter systemet vila i 1000 milisekunder
                        Thread.Sleep(1000);
                        //break bryter case "1" sekvensen
                        break;

                    //case "2" körs om strängen "2" angetts och lästs av via metoden "Console.Readline"
                    case "2":
                        Console.WriteLine("Programmet avslutas");
                        active = false;
                        //Metoden Thread.Sleep, låter systemet vila i 3000 milisekunder
                        Thread.Sleep(3000);
                        //Metoden Enviornment.Exit stränger ner programmet
                        Environment.Exit(0);
                        // break bryter case "2" sekvensen
                        break;

                    //default sekvens, körs om inget giltligt värde angetts
                    default:
                        Console.WriteLine("Ett fel inträffade, försök igen.");
                        //Metoden Thread.Sleep, låter systemet vila i 1000 milisekunder
                        Thread.Sleep(1000);
                        //break bryter default sekvensen
                        break;
                    }

                }

            }
        }
    }