using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagicEightBallServiceLib
{
    public class MagicEightBallService : IEightBall
    {
        public MagicEightBallService()
        {
            Console.WriteLine("The 8-Ball awaits your question...");
        }
        public string ObtainAnswerToQuestion(string userQuestion) 
        {
            string[] answers = { "A", "B", "C" };
            Random r = new Random();
            return answers[r.Next(answers.Length)];
        }
    }
}
