double[] MyArray;

            //TASK1//
            {
                Task(1, true);
                Console.WriteLine("Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве." +
                    "\n\t[345, 897, 568, 234] -> 2\n\n");

                MyArray = GenerateArray(4, 1, 10);
                PrintArray(MyArray);

                int EvenNumbers = 0;

                for (int i = 0; i < MyArray.Length; i++)
                {
                    if (MyArray[i] % 2 == 0)
                    {
                        EvenNumbers++;
                    }
                }
                Console.WriteLine($"Even numbers in an array = {EvenNumbers}");
            }

            //TASK2//
            {
                Task(2);
                Console.WriteLine("Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях." +
                    "\n\t[3, 7, 23, 12] -> 19" +
                    "\n\t[-4, -6, 89, 6] -> 0\n\n");


                MyArray = GenerateArray(10, 1, 10);
                PrintArray(MyArray);

                double SumOfOddPositions = 0;

                for (int i = 0; i < MyArray.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        SumOfOddPositions += MyArray[i];
                    }
                }
                Console.WriteLine($"Sum of numbers in odd array positions = {SumOfOddPositions}");
            }

            //TASK3//
            {
                Task(3);
                Console.WriteLine("Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива." +
                    "\n\t[345, 897, 568, 234] -> 2\n\n");

                MyArray = GenerateArray(10, 100, 999, true, 2);
                PrintArray(MyArray);

                double MaxNum = MyArray[0];
                double MinNum = MyArray[0];

                for (int i = 0; i < MyArray.Length; i++)
                {
                    if (MyArray[i] > MaxNum)
                    {
                        MaxNum = MyArray[i];
                    }
                    else
                    {
                        if (MyArray[i] < MinNum)
                        {
                            MinNum = MyArray[i];
                        }
                    }
                }
                Console.WriteLine($"MaxNum = {MaxNum}\n\n\tMinNum = {MinNum}\n\n\tnumber difference {MaxNum - MinNum}\n\n");
            }

            /*______________________________________________________________________________________________________________________________________*/
            int PrintNum(string Messadge)
            {
                Console.Write(Messadge);
                string NumString = Console.ReadLine();
                int NumInt = Convert.ToInt32(NumString);
                return NumInt;
            }

            double[] GenerateArray( int Size, int MinValue, int MaxValue, bool IsRealNumber = false, int decimals = 0)
            {
                double[] Array = new double[Size];
                Random Random = new Random();
                for (int i = 0; i < Size; i++)
                {
                    Array[i] = Random.Next(MinValue, MaxValue + 1);
                    if(IsRealNumber)
                    {
                        Array[i] += Math.Round(Random.NextDouble(), decimals);
                    }
                }
                return Array;
            }

            void PrintArray(double[] Array)
            {
                Console.Write("[");
                for (int i = 0; i < Array.Length - 1; i++)
                {
                    Console.Write($"{Array[i]}, ");
                }
                Console.WriteLine($"{Array[Array.Length - 1]}]\n");
            }

            /*______________________________________________________________________________________________________________________________________*/
            void Task(int TaskNum, bool IsFirstTask = false)
            {
                if (!IsFirstTask)
                {
                    Console.Write("\n\n\npress Enter to proceed to the next task\n\n");
                    Console.ReadKey();
                }
                Console.Write($"\n+++++++++++++++++++ Task {TaskNum} +++++++++++++++++++\n\n\n");
            }