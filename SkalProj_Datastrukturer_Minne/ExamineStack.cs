using System.Collections;

namespace SkalProj_Datastrukturer_Minne
{
    internal class ExamineStack
    {
        private Stack stack = new Stack();
        

        internal void ReverseText()
        {
            bool isAdding = true;
            Console.WriteLine("Insert a text to print out in revrese order.");

            do
            {
                string input = Console.ReadLine();

                switch(input)
                {
                    case "q":
                        isAdding = false;
                        break;

                    default: 
                        foreach (var c in input)
                        {
                            stack.Push(c);
                        }
                        Console.WriteLine("Your text in reverse order is : ");
                        while(stack.Count != 0)
                        {
                            Console.Write($"{stack.Pop()}");
                        }
                        break;
                }
            }
            while (isAdding);
        }
    }
}