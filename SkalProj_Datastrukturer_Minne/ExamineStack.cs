using System.Collections;

namespace SkalProj_Datastrukturer_Minne
{
    internal class ExamineStack
    {
        private Stack stack = new Stack();

        internal void ExamineStackMenu()
        {
            Console.Clear();
            Console.WriteLine("Type '+' to Reverse text.\nType 'q' to go back.");
        }

        internal void ReverseText()
        {
            bool isAdding = true;
            Console.WriteLine("Insert a text to print out in revrese order.");

            while (isAdding) 
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
            
        }
    }
}