using System;

namespace marshal_test
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int[] price = new int[] { 30845,756,1,02,128,358,018,37,0027,00046 };
            string[] name = new string[] { "Bitcoin", "Ethereum", "tether", "XRP", "Litecoin", "Bitcoin cash", "cardano", "BNB", "Tron", "Dogecoin" };

            for (int i = 0; i < name.Length; i++)
            {

                Console.WriteLine(num + " _ " + name[i] + " = " + price[i] + " $");
                num++;
             

            }
            Console.WriteLine("enter a coin name you want. ");
            
            switch ( Console.ReadLine())
            {
                case "Bitcoin":
                    Console.WriteLine(name[0] + " value" + " = " + price[0] + " $");
                    Console.WriteLine("you want to buy or sell ?");
                    switch (Console.ReadLine())
                    {
                        case "buy":
                            Console.WriteLine("enter how much you want to buy : ");
                            int adad = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine((adad * price[0]).ToString() + " $");
                            break;
                        case "sell":
                            Console.WriteLine("enter how much you want to sell : ");
                            int aad = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine((aad * price[0]).ToString() + " $");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    Console.WriteLine("you want to continue or cancel ?");
                    break;
                case "Ethereum":
                    Console.WriteLine(name[1] + " value" + " = " + price[1] + " $");
                    Console.WriteLine("you want to buy or sell ?");
                    switch (Console.ReadLine())
                    {
                        case "buy":
                            Console.WriteLine("enter how much you want to buy : ");
                            int adad = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine((adad * price[1]).ToString() + " $");
                            break;
                        case "sell":
                            Console.WriteLine("enter how much you want to sell : ");
                            int aad = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine((aad * price[1]).ToString() + " $");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    Console.WriteLine("you want to continue or cancel ?");
                    break;
                case "tether":
                    Console.WriteLine(name[2] + " value" + " = " + price[2] + " $");
                    Console.WriteLine("you want to buy or sell ?");
                    switch (Console.ReadLine())
                    {
                        case "buy":
                            Console.WriteLine("enter how much you want to buy : ");
                            int adad = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine((adad * price[2]).ToString() + " $");
                            break;
                        case "sell":
                            Console.WriteLine("enter how much you want to sell : ");
                            int aad = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine((aad * price[2]).ToString() + " $");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    Console.WriteLine("you want to continue or cancel ?");
                    break;
                case "XRP":
                    Console.WriteLine(name[3] + " value" + " = " + price[3] + " $");
                    Console.WriteLine("you want to buy or sell ?");
                    switch (Console.ReadLine())
                    {
                        case "buy":
                            Console.WriteLine("enter how much you want to buy : ");
                            int adad = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine((adad * price[3]).ToString() + " $");
                            break;
                        case "sell":
                            Console.WriteLine("enter how much you want to sell : ");
                            int aad = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine((aad * price[3]).ToString() + " $");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    Console.WriteLine("you want to continue or cancel ?");
                    break;
                case "Litecoin":
                    Console.WriteLine(name[4] + " value" + " = " + price[4] + " $");
                    Console.WriteLine("you want to buy or sell ?");
                    switch (Console.ReadLine())
                    {
                        case "buy":
                            Console.WriteLine("enter how much you want to buy : ");
                            int adad = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine((adad * price[4]).ToString() + " $");
                            break;
                        case "sell":
                            Console.WriteLine("enter how much you want to sell : ");
                            int aad = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine((aad * price[4]).ToString() + " $");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    Console.WriteLine("you want to continue or cancel ?");
                    break;
                case "Bitcoin cash":
                    Console.WriteLine(name[5] + " value" + " = " + price[5] + " $");
                    Console.WriteLine("you want to buy or sell ?");
                    switch (Console.ReadLine())
                    {
                        case "buy":
                            Console.WriteLine("enter how much you want to buy : ");
                            int adad = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine((adad * price[5]).ToString() + " $");
                            break;
                        case "sell":
                            Console.WriteLine("enter how much you want to sell : ");
                            int aad = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine((aad * price[5]).ToString() + " $");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    Console.WriteLine("you want to continue or cancel ?");
                    break;
                case "cardano":
                    Console.WriteLine(name[6] + " value" + " = " + price[6] + " $");
                    Console.WriteLine("you want to buy or sell ?");
                    switch (Console.ReadLine())
                    {
                        case "buy":
                            Console.WriteLine("enter how much you want to buy : ");
                            int adad = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine((adad * price[6]).ToString() + " $");
                            break;
                        case "sell":
                            Console.WriteLine("enter how much you want to sell : ");
                            int aad = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine((aad * price[6]).ToString() + " $");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    Console.WriteLine("you want to continue or cancel ?");
                    break;
                case "BNB":
                    Console.WriteLine(name[7] + " value" + " = " + price[7] + " $");
                    Console.WriteLine("you want to buy or sell ?");
                    switch (Console.ReadLine())
                    {
                        case "buy":
                            Console.WriteLine("enter how much you want to buy : ");
                            int adad = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine((adad * price[7]).ToString() + " $");
                            break;
                        case "sell":
                            Console.WriteLine("enter how much you want to sell : ");
                            int aad = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine((aad * price[7]).ToString() + " $");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    Console.WriteLine("you want to continue or cancel ?");
                    break;
                case "Tron":
                    Console.WriteLine(name[8] + " value" + " = " + price[8] + " $");
                    Console.WriteLine("you want to buy or sell ?");
                    switch (Console.ReadLine())
                    {
                        case "buy":
                            Console.WriteLine("enter how much you want to buy : ");
                            int adad = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine((adad * price[8]).ToString() + " $");
                            break;
                        case "sell":
                            Console.WriteLine("enter how much you want to sell : ");
                            int aad = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine((aad * price[8]).ToString() + " $");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    Console.WriteLine("you want to continue or cancel ?");
                    break;
                case "Dogecoin":
                    Console.WriteLine(name[9] + " value" + " = " + price[9] + " $");
                    Console.WriteLine("you want to buy or sell ?");
                    switch (Console.ReadLine())
                    {
                        case "buy":
                            Console.WriteLine("enter how much you want to buy : ");
                            int adad = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine((adad * price[9]).ToString() + " $");
                            break;
                        case "sell":
                            Console.WriteLine("enter how much you want to sell : ");
                            int aad = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine((aad * price[9]).ToString()+ " $");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    Console.WriteLine("you want to continue or cancel ?");
                    break;
                default:
                    Console.WriteLine("coin you want is not available");
                    break;
            }
            switch (Console.ReadLine())
            {
                case "continue":
                    Console.WriteLine("your change is completed");
                    Console.WriteLine("thank you for using my app");
                    break;
                case "cancel":
                    Console.WriteLine("canceled");
                    Console.WriteLine("thank you for using my app");
                    break;
                default :
                    Console.WriteLine("error");
                    break;
            }
            Console.ReadKey();
        }
    }
}
