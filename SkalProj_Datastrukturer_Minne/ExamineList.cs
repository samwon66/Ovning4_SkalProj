using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkalProj_Datastrukturer_Minne
{
    internal class ExamineList
    {
        private List<string> examineList = new List<string>();

        public int Count {  get { return examineList.Count; } }
        public int Capacity {  get { return examineList.Capacity; } }

        internal void ExamineListMenu()
        {
            Console.Clear();
            Console.WriteLine("Type '+' to add a name to the list.\nType '-' to remove a name from the list.\nType 'q' to go back.");
        }

        internal void AddToList()
        {
            bool isAdding = true;

            while (isAdding)
            {

                string input =  Console.ReadLine();
                switch(input)
                {
                    case "q":
                        isAdding = false;
                        break;

                    case "-":
                        RemoveFromList();
                        return;

                    default:
                        examineList.Add(input);
                        Console.WriteLine($"{input} has been added to the list.");
                        DisplayCountCapacity();
                        break;
                }
            }
            

        }

        internal void RemoveFromList()
        {
            bool isRemoving = true;
            Console.WriteLine("Enter the name to remove.");
            string input = Console.ReadLine();

            while (isRemoving)
            {
                switch (input)
                {
                    case "+":
                        AddToList();
                        return;

                    case "q":
                        isRemoving = false;
                        break;

                    default: 
                        Console.WriteLine(RemoveCheck(input));
                        DisplayCountCapacity();
                        Console.ReadLine();
                        break;

                }
            }
            
        }

        internal void DisplayCountCapacity()
        {
            Console.WriteLine($"Count: {Count}, capacity: {Capacity}");
        }

        internal string RemoveCheck(string userInput)
        {
            if (examineList.Remove(userInput))
            {
                return $"{userInput} removed from the list.";
            }
            else
            {
                return $"{userInput} was not found in the list.";
            }
        }
    }
}
