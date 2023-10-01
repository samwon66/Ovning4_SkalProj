using System.Collections;

namespace SkalProj_Datastrukturer_Minne
{
    internal class ExamineQueue
    {
        private Queue queue = new Queue();
        public int Count { get { return queue.Count; } }

        internal void ExamineQueueMenu()
        {
            Console.Clear();
            Console.WriteLine("Type '+' to add to the queue.\nType '-' to remove from the queue.\nType 'q' to go back.");
        }

        internal void AddToQueue()
        {
            bool iaAdding = true;
            Console.WriteLine("You are adding to the queue.\nPlease your name");

            do
            {
                string input = Console.ReadLine();

                switch (input)
                {
                    case "-":
                        return;

                    case "q":
                        iaAdding = false;
                        break;

                    default: 
                        queue.Enqueue(input);
                        Console.WriteLine($"{input} added to the queue.");
                        break;
                }
            }
            while (iaAdding);
        }

        internal void RemoveFromQueue()
        {
            bool isRemoving = true;
            Console.WriteLine("You want to remove from the queue.\nType 'Next' to process.");

            do
            {
                string input = Console.ReadLine();

                switch (input)
                {
                    case "+":
                        AddToQueue();
                        return;

                    case "q":
                        isRemoving = false;
                        break;

                    case "Next":
                        Console.WriteLine(LeaveQueue());
                        break;

                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
            }
            while(!isRemoving);
        }

        private string LeaveQueue()
        {
            if (Count > 0)
            {
                return $"{queue.Dequeue()} leaves the line.";
            }
            else
            {
                return $"No one in the line.";
            }
        }
    }
}