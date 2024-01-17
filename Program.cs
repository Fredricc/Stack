namespace Stack
{
    public class Stack
    {
        //private object obj;

        //public void Push(object obj)
        //{
        //    Stack<int> stack = new Stack<int>();
        //}

        //public object Pop()
        //{
        //    Peek(Push.stack);
        //    return obj;
        //}


        public void Clear()
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            //var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }
}