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

        internal void AddToList()
        {
            bool isAdding = true;

            do
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
            while (isAdding); 

        }

        internal void RemoveFromList()
        {
            bool isRemoving = true;
            string input = Console.ReadLine();

            do
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
                        examineList.Remove(RemoveCheck(input));
                        DisplayCountCapacity();
                        break;

                }
            }
            while (isRemoving);
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
