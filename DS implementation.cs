//Stack implementation
namespace StackImplementation
{
    internal class Stack
    //internal keyword = type or member can be accessed by any code in the assembly in which it's declared, or from within a derived class in another assembly
    {
        static readonly int MAX = 1000;
        int top;
        int[] stack = new int[MAX];
    
        bool IsEmpty()
        {
            return (top < 0);
        }
        public Stack()
        {
            top = -1;
        }
        internal bool Push(int data)
        {
            if (top >= MAX)
            {
                System.Console.WriteLine("Stack Overflow");
                return false;
            }
            else
            {
                stack[++top] = data;
                return true;
            }
        }
  
        internal int Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return 0;
            }
            else
            {
                int value = stack[top--];
                return value;
            }
        }
  
        internal void Peek()
        {
            if (top < 0)
            {
                Console.WriteLine("Empty here :< So lonely bro...");
                return;
            }
            else
                Console.WriteLine("Nah, you got {0} on top Xd There are {1} in total @@", stack[top], stack.Count());
        }
  
        internal void PrintStack()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
            {
                Console.WriteLine("Items in the Stack are :");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }
    }
  
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();

            Console.WriteLine("Welcome to the Stack test system\nEnter which operations do you want to execute:\n (1) Check stack's 'loneliness' :<\n (2) Push new item in Stack :>\n (3) Show me the stackkk :3\n (4) Kill the one on top!!!\n (q) Lemme out of here! Byeee _UwU_");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Lemme check B) Hmmm...");
                    myStack.Peek();
                    break;
                case "2":
                    Console.WriteLine("Push wot? :| Enter it here: ");
                    string newItem = Console.ReadLine();
                    myStack.Push(Convert.ToInt16(newItem));
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "q":
                    Console.WriteLine("You really sure you wanna do dis? :< (y/n)");
                    if (userInput == "y") {Console.WriteLine("Kay...Fine, ups to you tho :< Cya later");}
                    else  {Console.WriteLine("Hah... You choose to quit but not sure? Wot wrong with ya? Fine :> You'r out anyway hmihmi ");}
                    break;
            }
  
            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(30);
            myStack.Push(40);
            myStack.PrintStack();
            myStack.Peek();
            Console.WriteLine("Item popped from Stack : {0}", myStack.Pop());
            myStack.PrintStack();
        }
    }
}