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
        static void Main(string[] args)
        {
            #region Q1  Assignment 02 implement a function to reverse the elements of a queue using a stack.Given a Queue,
            Queue<int> Que = new Queue<int>();
            Que.Enqueue(1);
            Que.Enqueue(2);
            Que.Enqueue(3);
            Console.WriteLine("Before Reversed");
            foreach (var item in Que)
            {
                Console.WriteLine(item);
            }
            Stack<int> Reversed = Reverse(Que);
            Console.WriteLine("after Reversed");
            foreach (int i in Reversed)
            {
                Console.WriteLine(i);
            }

            #endregion
        }
    }
}
