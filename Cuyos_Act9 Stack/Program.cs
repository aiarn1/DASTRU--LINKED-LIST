using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            var stack = new List<int>(); // Initialize stack as empty (top is end of list)
            bool exit = false;

            while (!exit)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("-----Stack Operations-----");
                Console.WriteLine("1) Push ");
                Console.WriteLine("2) Pop ");
                Console.WriteLine("3) Peek ");
                Console.WriteLine("4) Display stack ");
                Console.WriteLine("5) Count ");
                Console.WriteLine("6) IsEmpty ");
                Console.WriteLine("0) Exit ");
                Console.Write("Enter choice: ");    
                string input = Console.ReadLine();
                Console.WriteLine();
                try
                {
                    if (!int.TryParse(input, out int choice))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        throw new FormatException("Invalid menu choice. Please enter a number.");        
                    }

                    switch (choice)
                    {
                        case 1:
                            Push(stack);
                            break;
                        case 2:
                            int popped = Pop(stack);
                            Console.WriteLine("Popped : " + popped);
                            break;
                        case 3:
                            int top = Peek(stack);
                            Console.WriteLine("Top value : " + top);
                            break;
                        case 4:
                            PrintStack(stack);
                            break;
                        case 5:
                            Console.WriteLine("Count : " + Count(stack));
                            break;
                        case 6:
                            Console.WriteLine("Is the stock is empty? : " + (IsEmpty(stack) ? "Yes" : "No"));
                            break;
                        case 0:
                            exit = true;
                            Console.WriteLine("Exiting program.");
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid choice. Please select a valid option.");
                            break;
                    }
                }
                catch (FormatException fx)
                {
                    Console.WriteLine("Input error: " + fx.Message);
                }
                catch (InvalidOperationException ioex)
                {
                    Console.WriteLine("Operation error: " + ioex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Unexpected error: " + ex.Message);
                }
            }
            Console.ReadKey();
        }


        // Push: prompts user for an integer and pushes it onto the stack
        static void Push(List<int> stack)
        {
            Console.Write("Enter integer to push: ");
            string valStr = Console.ReadLine();
            if (!int.TryParse(valStr, out int value))
            {
                throw new FormatException("Invalid integer value.");
            }

            stack.Add(value);
            Console.WriteLine("Pushed: " + value);
            Console.WriteLine();
        }

        // Pop: removes and returns the top element; throws if empty
        static int Pop(List<int> stack)
        {
            if (stack.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                throw new InvalidOperationException("Cannot pop from an empty stack.");
            }

            int value = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);
            return value;
        }

        // Peek: returns the top element without removing; throws if empty
        static int Peek(List<int> stack)
        {
            if (stack.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                throw new InvalidOperationException("Cannot peek an empty stack.");
            }

            return stack[stack.Count - 1];
        }

        // PrintStack: displays stack contents from top to bottom
        static void PrintStack(List<int> stack)
        {
            if (stack.Count == 0)
            {
                Console.WriteLine("Stack is empty.");
                return;
            }

            Console.WriteLine("Stack (top -> bottom):");
            for (int i = stack.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(stack[i]);
            }
        }
        static bool IsEmpty(List<int> stack) => stack.Count == 0;
        static int Count(List<int> stack) => stack.Count;
    
    }

}
