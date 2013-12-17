using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MagicEightBallServiceClient.ServiceReference1;

namespace MagicEightBallServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            EightBallClient client = new EightBallClient();


            while (true)
            {
                Console.ReadKey();
                Console.WriteLine(client.ObtainAnswerToQuestion("hehe"));
            }
            //Console.WriteLine("****  Ask the Magic 8 Ball *****\n");
            //using (EightBallClient ball = new EightBallClient()) 
            //{
            //    Console.WriteLine();
            //}
        }
    }
}
