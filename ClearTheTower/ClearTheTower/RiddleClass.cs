using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearTheTower
{
     class RiddleClass
    {
        List<Func<Boolean>> functions;
        public RiddleClass()
        {
            functions = new List<Func<Boolean>>();
            functions.Add(Riddle1);
            functions.Add(Riddle2);
            functions.Add(Riddle3);
            functions.Add(Riddle4);
        }
        public Func<Boolean> GetRiddle(int index)
        {
            return functions[index];
        }
        public List<Func<Boolean>> GetRiddlesList()
        {
            return functions;
        }
        public int GetNumberOfRiddles()
        {
            return functions.Count;
        }
        public bool Riddle1()
        {
            Console.WriteLine("|                                                          |");
            Console.WriteLine("| What has hands, but can’t clap?                          |");
            Console.WriteLine("|                                                          |");
            string answer = null;
            string correct_answer = "clock";
            while (true)
            {
                var key = System.Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                    break;
                answer += key.KeyChar;
            }
            if(correct_answer.Equals(answer, StringComparison.CurrentCultureIgnoreCase)==true)
            {
                Console.WriteLine("| You are correct, the answer is the clock                 |");
                Console.WriteLine("|                                                          |");
                return true;
            }
            else
            {
                Console.WriteLine("| You are incorrect, the answer is the clock               |");
                Console.WriteLine("|                                                          |");
                return false;
            }
        }
        public bool Riddle2()
        {
            Console.WriteLine("|                                                          |");
            Console.WriteLine("| What is always in front of you but can’t be seen?        |");
            Console.WriteLine("|                                                          |");
            string answer = null;
            string correct_answer = "future";
            while (true)
            {
                var key = System.Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                    break;
                answer += key.KeyChar;
            }
            if (correct_answer.Equals(answer, StringComparison.CurrentCultureIgnoreCase) == true)
            {
                Console.WriteLine("| You are correct, the answer is the future                |");
                Console.WriteLine("|                                                          |");
                return true;
            }
            else
            {
                Console.WriteLine("| You are incorrect, the answer is the future              |");
                Console.WriteLine("|                                                          |");
                return false;
            }
        }
        public bool Riddle3()
        {
            Console.WriteLine("|                                                          |");
            Console.WriteLine("| The more of this there is, the less you see. What is it? |");
            Console.WriteLine("|                                                          |");
            string answer = null;
            string correct_answer = "darkness";
            while (true)
            {
                var key = System.Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                    break;
                answer += key.KeyChar;
            }
            if (correct_answer.Equals(answer, StringComparison.CurrentCultureIgnoreCase) == true)
            {
                Console.WriteLine("| You are correct, the answer is the darkness              |");
                Console.WriteLine("|                                                          |");
                return true;
            }
            else
            {
                Console.WriteLine("| You are incorrect, the answer is the darkness            |");
                Console.WriteLine("|                                                          |");
                return false;
            }
        }
        public bool Riddle4()
        {
            Console.WriteLine("|                                                          |");
            Console.WriteLine("|  I am an odd number. Take away a letter and I become     |");
            Console.WriteLine("|  even. What number am I?                                 |");
            Console.WriteLine("|                                                          |");
            string answer = null;
            string correct_answer = "seven";
            while (true)
            {
                var key = System.Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                    break;
                answer += key.KeyChar;
            }
            if (correct_answer.Equals(answer, StringComparison.CurrentCultureIgnoreCase) == true)
            {
                Console.WriteLine("| You are correct, the answer is seven                     |");
                Console.WriteLine("|                                                          |");
                return true;
            }
            else
            {
                Console.WriteLine("| You are incorrect, the answer is seven                   |");
                Console.WriteLine("|                                                          |");
                return false;
            }
        }
    }
}
