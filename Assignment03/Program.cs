namespace Assignment03
{
    internal class Program
    {
        public static Stack<int> Reverse(Queue<int> Que)
        {
            Stack<int> Stack = new Stack<int>();
            //Stack.Push(Que.Dequeue());
            //Stack.Push(Que.Dequeue());
            //Stack.Push(Que.Dequeue());
            while (Que.Count > 0)
            {
                Stack.Push(Que.Dequeue());
            }


            return Stack;
        }

        static string IsBalanced(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (stack.Count == 0)
                    {
                        return "Not Balanced";
                    }

                    char top = stack.Pop();
                    if ((c == ')' && top != '(') ||
                        (c == ']' && top != '[') ||
                        (c == '}' && top != '{'))
                    {
                        return "Not Balanced";
                    }
                }
            }

            return stack.Count == 0 ? "Balanced" : "Not Balanced";
        }
        static void Main(string[] args)
        {
            #region Q1  Assignment 02 implement a function to reverse the elements of a queue using a stack.Given a Queue,
            //Queue<int> Que = new Queue<int>();
            //Que.Enqueue(1);
            //Que.Enqueue(2);
            //Que.Enqueue(3);
            //Console.WriteLine("Before Reversed");
            //foreach (var item in Que)
            //{
            //    Console.WriteLine(item);
            //}
            //Stack<int> Reversed = Reverse(Que);
            //Console.WriteLine("after Reversed");
            //foreach (int i in Reversed)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Q2  Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.
            string inputString = "[()]{})";
            Console.WriteLine(IsBalanced(inputString));  //Not Balanced

            inputString = "[(){}]";
            Console.WriteLine(IsBalanced(inputString)); // Balanced
            #endregion

        }
    }
}
