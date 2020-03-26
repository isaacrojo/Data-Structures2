using System;

namespace Data_Structures_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(3);
            stack.Push(5);
            stack.Push(7);
            stack.Push(11);

            System.Console.WriteLine(stack);

            int poppedElement;

            poppedElement = stack.Pop();
            System.Console.WriteLine($"poppedElement => {poppedElement}");
            System.Console.WriteLine(stack);

            poppedElement = stack.Pop();
            System.Console.WriteLine($"poppedElement => {poppedElement}");
            System.Console.WriteLine(stack);

           //print top
            int topElement;
            topElement = stack.Top();
            System.Console.WriteLine($"topElement = {topElement}");
            System.Console.WriteLine(stack);

            //print bottom
            int bottomElement;
            bottomElement = stack.Bottom();
            System.Console.WriteLine($"bottomElement = {bottomElement}");
            System.Console.WriteLine(stack);


        }
    }
}
