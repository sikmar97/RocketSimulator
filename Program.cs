using System;
using System.Threading;
using static System.Console;

namespace RocketSimulator
{
    class Program
    {
        static Rocket[] rocketList = new Rocket[10];
        
       static void Main(string[] args)
        {
            bool exit = false;

            uint rocketListIndex = 0;

            while (exit == false)
            {
                Clear();
                CursorVisible = false;
                SetCursorPosition(2, 1);
                WriteLine("1. Add Rocket");
                SetCursorPosition(2, 2);
                WriteLine("2. List Rockets");
                SetCursorPosition(2, 3);
                WriteLine("3. Simulate speed after time period");
                SetCursorPosition(2, 4);
                WriteLine("4. Exit");

                Console.CursorVisible = false;

                ConsoleKeyInfo input = ReadKey(true);

                Clear();

                switch (input.Key)
                {
                    case ConsoleKey.D1:
                        CursorVisible = false;

                        Console.WriteLine("Choose Rocket:");

                        Console.WriteLine("1.  Starship SpaceX");

                        Console.WriteLine("2.  Falcon 9 SpaceX");

                        ConsoleKeyInfo keyPress = ReadKey(true);

                        Clear();

                        switch (keyPress.Key)
                        {
                            case ConsoleKey.D1:



                                Rocket theRocket = new Starship();

                                string rocketPrev = theRocket.Brand;
                                
                                theRocket = SearchRocketBy(rocketPrev);

                                Clear();
                                if (theRocket == null)
                                {
                                    Rocket newStarship = new Starship();
                                    rocketList[rocketListIndex++] = newStarship;
                                    Console.WriteLine("Rocket Added");
                                    Thread.Sleep(2000);
                                }
                                else
                                {
                                    WriteLine("Rocket already added");

                                    Thread.Sleep(2000);
                                }
                                break;
                        

                    case ConsoleKey.D2:

                                Rocket theRocket2 = new Falcon_9();

                                string rocketPrev2 = theRocket2.Brand;

                                theRocket2 = SearchRocketBy(rocketPrev2);

                                Clear();
                                if (theRocket2 == null)
                                {
                                    Rocket newFalcon9 = new Falcon_9();
                                    rocketList[rocketListIndex++] = newFalcon9;
                                    Clear();
                                    Console.WriteLine("Rocket Added");
                                    Thread.Sleep(2000);
                                }
                                else
                                {
                                    WriteLine("Rocket already added");

                                    Thread.Sleep(2000);
                                }
                                break;
                               

                               
                        }

                       
                        break;

                    case ConsoleKey.D2:
                        WriteLine(" Rocket         Manifacture       ");
                        WriteLine("-----------------------------------------");

                        foreach (Rocket rocket in rocketList)
                        {
                            if (rocket == null)
                            {
                                continue;
                            }
                            else
                            {
                                Console.WriteLine(" " + rocket.Brand + ",           " + rocket.Model);
                            }
                        }

                        WriteLine("");
                        CursorVisible = true;
                        SetCursorPosition(1, 12);
                        Write("<Press Any Key To Continue>");
                        ReadKey();
                        break;

                    case ConsoleKey.D3:

                        Console.Write("Engine Burn Per Seconds: ");

                        var sec = int.Parse(Console.ReadLine());

                        Console.Clear();

                        Console.WriteLine(" Rocket                  Speed (km/s)        Fuel");
                        Console.WriteLine("----------------------------------------------------");

                        foreach (Rocket rocket in rocketList)
                        {
                            if (rocket == null) continue;
                            rocket.EngineBurn(sec);

                            Console.WriteLine("" + rocket.Brand + ", " + rocket.Model + "            " + rocket.VelocityInKilometersPerSecond + "            " + rocket.FuelAmountInKilograms);
                        }

                        WriteLine("");
                        CursorVisible = true;
                        SetCursorPosition(1, 12);
                        Write("<Press Any Key To Continue>");
                        ReadKey();

                        break;

                    case ConsoleKey.D4:

                        exit = true;

                        break;
                }
            }

        }
        private static Rocket SearchRocketBy(string brand)
        {
            Rocket rocketReferenceToReturn = null;

            foreach (Rocket rocketReference in rocketList)
            {
                if (rocketReference == null) continue;

                if (rocketReference.Brand ==  brand)
                {
                    rocketReferenceToReturn = rocketReference;
                    break;
                }
            }

            return rocketReferenceToReturn;
        }
    }
}