using System;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>

        //Frågan 1: Stacken: stacken används främst för att hålla reda på exekveringsordningen i ett program och för att lagra lokala variabler inne i funktioner.
        //Den fungerar som en stapel där det senaste tillagda elementet är det första som tas bort. Åtkomst och hantering på stacken är snabb eftersom den är organiserad och strukturerad.
        //Heapen : heapen används för att lagra stora eller komplicerade saker som tar upp mycket plats som till exempel bilder, långa texter osv. Det är som en stor lagringsplats där vi kan 
        //ställa in saker och hämta dem senare när vi behöver dem. Som en virtuell låda där vi kan spara olika saker. När vi lägger till saker i heapen så kommer de att stanna där tills vi säger åt datorn att ta bort dem.

        //exempel: Tänk på stacken som en bok där du kan bläddra fram och tillbaka. Information som är staplat på varann i form sidor i en bok. 
        //exempel:Medan heapen är snarare ett bibliotek, med adresser till böckerna. Men böckerna kan ju byta plats. Det kan inte informationen på sidor göra. 

        //Frågan 2: Value types: En variabel av en värdetyp som innehåller själva datavärdet, dessa lagras i stacken. Exempel på value types är int, char, bool etc.
        // Reference types: En variabel som innehåller en referens (adress i heapen) till platsen där datan lagras. 

        //Frågan 3: I första metoden kopierar y bara x från början. sedan ändras värdet på y till 4 men x påverkas inte eftersom y bara har en kopia av x-värdet. Så när man returnerar x i slutet så kommer den fortfarande att bara vara 3.
        // I andra metoden skapas två instanser av MyInt där x.MyValue sätts till tre. sedan tilldelas y värdet av x, vilket innebär att både x och y nu pekar på samma objekt. Så när man returnerar x.MyValue i slutet så är det 4 för 
        // att både x och y pekar mot värdet 4. 
        static void Main()
        {
            while (true)
            {
                MainMenu();
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
            //Frågan 6: När man vet att hur många element som man behöver är det bättre att skapa en array.
            
            ExamineList examineList = new ExamineList();
            bool quit = false;

            do
            {
                examineList.ExamineListMenu();
                char userChoice = InputCheck();

                switch (userChoice)
                {
                    case '+':
                        Console.WriteLine("Add name to the list.");
                        examineList.AddToList();
                        Console.Clear();

                        break;

                    case '-':
                        Console.WriteLine("Remove name from the list.");
                        examineList.RemoveFromList();
                        Console.Clear();
                        break;

                    case 'q':
                        Console.Clear();
                        quit = true;
                        break;

                    default:
                        Console.WriteLine("You have enter an invalid input. Please try again.");
                        Console.ReadKey();
                        break;
                }

            }
                while (!quit);
            
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
                examineQueue.ExamineQueueMenu();

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
                examineStack.ExamineStackMenu();
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

        

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

            CheckParanthesis checkParanthesis = new CheckParanthesis();
            bool quit = false;

            do
            {
                checkParanthesis.CheckParanthesisMenu();
                char userChoice = InputCheck();

                switch (userChoice)
                {
                    case '+':
                        checkParanthesis.isCorrectForm();
                        Console.Clear();
                        break;

                    case 'q':
                        quit = true;
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Use '+' followed by a text of your choice.");
                        break;
                }
            }
            while (!quit);

        }

        private static void MainMenu()
        {
            Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                                + "\n1. Examine a List"
                                + "\n2. Examine a Queue"
                                + "\n3. Examine a Stack"
                                + "\n4. CheckParanthesis"
                                + "\n0. Exit the application");
        }
        private static char InputCheck()
        {
            char input = ' ';

            try
            {
                input = Console.ReadLine()[0];
            }
            catch (IndexOutOfRangeException)
            {
                Console.Clear();
                Console.WriteLine("Please enter some input.");
            }
            return input;
        }

    }
}

