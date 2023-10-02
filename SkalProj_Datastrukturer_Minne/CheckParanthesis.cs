namespace SkalProj_Datastrukturer_Minne
{
    internal class CheckParanthesis
    {
        private Stack<char> stack = new Stack<char>();
        //public int Count { get { return stack.Count; } }

        internal void CheckParanthesisMenu()
        {
            Console.WriteLine("Type '+' to check paranthesis.\nType 'q' to go back to main menu.");
        }

        internal void isCorrectForm()
        {
            bool isChecking = true;

            while (isChecking)
            {
                bool isCorrect = true;
                string input = Console.ReadLine();
                
                if (input == "q")
                {
                    isChecking = false;
                    return;
                }

                foreach (var c in input)
                {
                    stack.Push(c);

                    switch(c)
                    {
                        case '(':
                            if (stack.Pop() != ')') { isCorrect = false; }
                            break;

                        case '[':
                            if (stack.Pop() != ']') { isCorrect = false; }
                            break;

                        case '{':
                            if (stack.Pop() != '}') { isCorrect = false; }
                            break;

                    }
                }
                if (isCorrect) { Console.WriteLine("Correct format"); }
                else { Console.WriteLine("Incorrect format"); }
            }
            


            
        }
    }
}