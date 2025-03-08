using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello Welcome in this program");

            List<int> list = new List<int>();
            string choice;
            do
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("P - Print numbers");
                Console.WriteLine("A - Add a number");
                Console.WriteLine("M - Display mean of the numbers");
                Console.WriteLine("S - Display the smallest number");
                Console.WriteLine("L - Display the largest number");
                Console.WriteLine("F - Find a number in the list");
                Console.WriteLine("C - Clear the list");
                Console.WriteLine("W - Swap two elements");
                Console.WriteLine("Q - Quit");
                Console.Write("Enter your choice: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "P":
                    case "p":
                        if (list.Count == 0)
                            Console.WriteLine("[] - the list is empty");
                        else
                        {
                            Console.Write("[ ");
                            for (int i = 0; i < list.Count; i++)
                                Console.Write($"{list[i]} ");
                            Console.Write("]");
                        }

                        break;
                    case "A":
                    case "a":
                        Console.Write("Enter a number to add: ");
                        int number = Convert.ToInt32(Console.ReadLine());
                        if (list.Contains(number))
                            Console.WriteLine($"{number} is already in the list.");
                        else
                        {
                            list.Add(number);
                            Console.WriteLine($"{number} added.");
                            Console.Write("[ ");
                            for (int i = 0; i < list.Count; i++)
                                Console.Write($"{list[i]} ");
                            Console.Write("]");
                        }

                        break;
                    case "M":
                    case "m":
                        if (list.Count == 0)
                            Console.WriteLine("Unable to calculate the mean - no data");
                        else
                        { int sum = 0;
                            for (int i = 0; i < list.Count; i++)
                                sum += list[i];
                            Console.WriteLine($"Mean: {sum / list.Count}");
                        }

                        break;
                    case "S":
                    case "s":
                        if (list.Count==0)
                            Console.WriteLine("Unable to determine the smallest number - list is empty");
                        else
                        {
                            int smallest = list[0];
                            for (int i = 1; i < list.Count; i++)
                                if (list[i] < smallest)
                                    smallest = list[i];
                            Console.WriteLine($"The smallest number is {smallest}");
                        }
                        break;
                    case "L":
                    case "l":
                        if (list.Count == 0)
                            Console.WriteLine("Unable to determine the largest number - list is empty");
                        else
                        {
                            int largest = list[0];
                            for (int i = 1; i < list.Count; i++)
                                if (list[i] > largest)
                                    largest = list[i];
                            Console.WriteLine($"The largest number is {largest}");
                        }
                        break;

                    case "F":
                    case "f":
                        Console.Write("Enter a number to find: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        if (list.Count==0)
                            Console.WriteLine("Unable to find the number - list is empty");
                        else
                        {
                            bool found = false;
                            int index = -1;
                            for (int i = 0; i < list.Count; i++)
                                if (list[i] == num)
                                {
                                    found = true;
                                    index = i;
                                    break;
                                }
                            if (found)
                                Console.WriteLine($"{num} found at index {index}");
                            else
                                Console.WriteLine($"{num} not found");
                        }
                        
                        break;
                    case "C":
                    case "c":
                        list.Clear();
                        Console.WriteLine("List cleared");
                        break;
                    case "W":
                    case "w":
                        if (list.Count < 2)
                            Console.WriteLine("Unable to swap - list has less than two elements");
                        else
                        {
                            Console.Write("Enter the first index to swap: ");
                            int index1 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter the second index to swap: ");
                            int index2 = Convert.ToInt32(Console.ReadLine());
                            if (index1 < 0 || index1 >= list.Count || index2 < 0 || index2 >= list.Count)
                                Console.WriteLine("Unable to swap - invalid index");
                            else
                            {
                                int temp = list[index1];
                                list[index1] = list[index2];
                                list[index2] = temp;
                                Console.WriteLine("Elements swapped");
                                Console.Write("[ ");
                                for (int i = 0; i < list.Count; i++)
                                    Console.Write($"{list[i]} ");
                                Console.Write("]");
                            }
                        }
                        break;



                    case "Q":
                    case "q":
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
            while (true);
        }
    }
}
