using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            string operation = Console.ReadLine();
            while (operation!="end")
            {
                string[] operationArr = operation
                .Split(" ")
                .ToArray();
                if (operationArr[0] == "exchange")
                {
                    if (operation[1]>=arr.Length || operation[1] <=0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    NewMethod(arr, operationArr);
                    
                }
                else if (operationArr[0] == "max")
                {

                }




                operation = Console.ReadLine();
            }
            
        }

        private static void NewMethod(int[] arr, string[] operationArr)
        {

            int index = int.Parse(operationArr[1]);
            int[] newArr = new int[arr.Length];
            int caunt = 0;
            for (int i = index + 1; i < arr.Length; i++)
            {
                newArr[caunt] = arr[i];
                caunt++;
            }
            int secondCaunt = caunt;
            for (int i = 0; i < arr.Length - caunt; i++) /*[1, 2, 3, 4, 5] -> exchange 2->result: [4, 5, 1, 2, 3]*/
            {
                newArr[secondCaunt] = arr[i];
                secondCaunt++;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = newArr[i];
            }
        }
    }
}
