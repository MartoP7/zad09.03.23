using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha09._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //list numbers
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            //command input
            string command = Console.ReadLine();

            Console.WriteLine("Въведи команда:");
            //loop
            while (command != "print")
            {
                //split parts
                string[] arr = command.Split();

                //get command
                string action = arr[0];

                //PUSH
                if (action == "push")
                {
                    int number = int.Parse(arr[1]);
                    numbers.Add(number);
                }
                //POP
                else if (action == "pop")
                {
                    if (numbers.Count > 0)
                    {
                        int number = numbers[numbers.Count - 1];
                        numbers.RemoveAt(numbers.Count - 1);
                        Console.WriteLine(number);
                    }
                }
                //SHIFT
                else if (action == "shift")
                {
                    if (numbers.Count > 0)
                    {
                        int number = numbers[numbers.Count - 1];
                        numbers.RemoveAt(numbers.Count - 1);
                        numbers.Insert(0, number);
                    }
                }
                //ADD MANY
                else if (action == "addMany")
                {
                    int index = int.Parse(arr[1]);

                    if (index >= 0 && index < numbers.Count)
                    {
                        List<int> numbersToAdd = new List<int>();

                        for (int i = 2; i < arr.Length; i++)
                        {
                            int numberToAdd = int.Parse(arr[i]);
                            numbersToAdd.Add(numberToAdd);
                        }

                        numbers.InsertRange(index, numbersToAdd);
                    }
                }
                //REMOVE
                else if (action == "remove")
                {
                    int index = int.Parse(arr[1]);

                    if (index >= 0 && index < numbers.Count)
                    {
                        numbers.RemoveAt(index);
                    }
                }

                command = Console.ReadLine();
            }

            numbers.Reverse();

            //print
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}