using System;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */


            //Frågan 2: När count är lika mycket som capacity.
            //Frågan 3: Kapacitet blir dubbelt så mycket.
            //Frågan 4: Listan har en underliggande array och arrayer har alltid en fixerad storlek.
            //Det blir väldigt ineffektivt för listan att skapa en ny array och kopiera alla nuvarande element till den underliggande arrayen varje gång ett nytt element läggs till i listan.
            //Därför dubblerar den sin capacity bara ibland när count blir större än capacity.
            //Frågan 5: Nej
            //Frågan 6: 
            
            ExamineList examineList = new ExamineList();
            bool quit = false;

            do
            {
                ExamineListMenu();
                char userChoice = InputCheck();

                switch (userChoice)
                {
                    case '+':
                        Console.WriteLine("Add name to the list.\nPlease enter the name to add.");
                        examineList.AddToList();
                        Console.Clear();

                        break;

                    case '-':
                        Console.WriteLine("Remove name from the list.\nPlease enter the name you want to remove.");
                        examineList.RemoveFromList();
                        break;

                    case 'q':
                        Console.Clear();
                        return;

                    default:
                        Console.WriteLine("You have enter an invalid input. Please try again.");
                        break;
                }

            }
                while (!quit);
            
        }


        private static void ExamineListMenu()
        {
            Console.Clear();
            Console.WriteLine("Type '+' to add a name to the list.\nType '-' to remove a name from the list.\nType 'q' to go back.");
        }

        private static char InputCheck()
        {
            char input = ' ';

            try
            {
                input = Console.ReadLine()[0];
            }
            catch(IndexOutOfRangeException)
            {
                Console.Clear();
                Console.WriteLine("Please enter some input.");
            }
            return input;
        }
       

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */

            ExamineQueue examineQueue = new ExamineQueue();
            bool quit = false;

            do
            {
                ExamineQueueMenu();

                char userChoice = InputCheck();

                switch (userChoice)
                {
                    case '+':
                        //Console.WriteLine("Add name to the list.\nPlease enter the name to add.");
                        examineQueue.AddToQueue();
                        Console.Clear();

                        break;

                    case '-':
                        //Console.WriteLine("Remove name from the list.\nPlease enter the name you want to remove.");
                        examineQueue.RemoveFromQueue();
                        break;

                    case 'q':
                        quit = true;
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("You have enter an invalid input. Please try again.");
                        break;
                }
            }
            while (!quit);
        }

        private static void ExamineQueueMenu()
        {
            Console.Clear();
            Console.WriteLine("Type '+' to add to the queue.\nType '-' to remove from the queue.\nType 'q' to go back.");
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */

            ExamineStack examineStack = new ExamineStack();
            bool quit = false;

            do
            {
                ExamineStackMenu();
                char userChoice = InputCheck();

                switch(userChoice)
                {
                    case '+':
                        examineStack.ReverseText();
                        break;

                    case 'q':
                        quit = true;
                        break;

                    default:
                        Console.WriteLine("Wrong input.");
                        break;
                }
            }
            while (!quit);
        }

        private static void ExamineStackMenu()
        {
            Console.Clear();
            Console.WriteLine("Type '+' to Reverse text.\nType 'q' to go back.");
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

        }

    }
}

