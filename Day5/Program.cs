using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace Day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //***Day5 Task1***
            //****************

            /*
            //Making a list with random numbers
            Random rnd = new Random();
            List<int> rndList = new List<int>();
            for(int i = 0; i < 10; i++)
            {
                rndList.Add(rnd.Next(1, 10));
            }
            //List output
            Console.WriteLine("Here is your list: ");
            foreach(int item in rndList)
            {
                Console.WriteLine(item);
            }
            */

            //***Day5 Task2***
            //****************

            /*
            List<string> StudentList = new List<string>();
            StudentList.Add("Drasius");
            StudentList.Add("Evelina");
            StudentList.Add("Ceslova");
            StudentList.Add("Bronius");

            List<string> StudentLate = new List<string>();
            StudentLate.Add("Aurimas");

            StudentList.AddRange(StudentLate);
            Console.WriteLine(String.Join(",", StudentList));
            StudentList.Sort();
            Console.WriteLine(String.Join("\n", StudentList));
            //Or output with foreach()
            */

            //***Day5 Task3***
            //****************

            /*
            //Initial array of names
            string[] GreatString = { "Cercil", "Bush",
                        "Rusvelt", "Orban" };
            //Copying array to list
            List<string> GreatList = new List<string>(GreatString);
            //Adding two names
            GreatList.Add("Napoleonas");
            GreatList.Add("Asterisas");
            //Output of the full list
            Console.WriteLine("The full list: ");
            Console.WriteLine(String.Join(",", GreatList));
            //Romoving one item from the list
            GreatList.RemoveAt(3);
            //Replacing Napoleonas
            int index = GreatList.IndexOf("Napoleonas");
            GreatList[index] = "Kleopatra";
            //Output of the new list
            Console.WriteLine("The final list: ");
            foreach (var item in GreatList)
            {
                Console.WriteLine(item);
            }
            */

            //***Day5 Task4***
            //****************

            /*
            //Generation of random marks
            Random rnd = new Random();
            int[] marks = new int[10];
            for(int i = 0; i < marks.Length; i++)
            {
                marks[i] = rnd.Next(1,11);
            }
            //Array to list
            List<int> markList = new List<int>(marks);
            //Showing the marks
            Console.WriteLine("All the initial marks: ");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write(marks[i] + " ");
            }
            Console.WriteLine();
            //User actions
            bool goodToGo = true;
            while (goodToGo)
            {
                Console.WriteLine("Your further actions: ");
                Console.WriteLine("0 - Add, 1 - Del, 2 - Ins, 3 - Avg, 4 - Exit");
                string actUser = Console.ReadLine();
                int actReal;
                goodToGo = int.TryParse(actUser, out actReal);
                //Executing selection
                if(goodToGo)
                {
                    switch(actReal)
                    {
                        case 0:
                            Console.WriteLine("Enter a new mark");
                            markList.Add(int.Parse(Console.ReadLine()));
                            break;
                        case 1:
                            Console.WriteLine("Enter the index (0 - " + markList.Count +  ") of mark to be removed");
                            markList.RemoveAt(int.Parse(Console.ReadLine()));
                            break;
                        case 2:
                            Console.WriteLine("At which index (0 - " + markList.Count + ") insert your mark");
                            markList.Insert(int.Parse(Console.ReadLine()), rnd.Next(1, 11));
                            break;
                        case 3:
                            double average = markList.Average();
                            Console.WriteLine("Average mark is {0}", average);
                            break;
                        case 4:
                            Console.WriteLine("Exit the program? y/n");
                            if (Console.ReadLine() == "y")
                            {
                                goodToGo = false;
                                break;
                            }
                            else continue;
                        case > 4:
                            Console.WriteLine("No such option.Try again");
                            continue;
                    }
                }
            }
            */

            //***Day5 Task5***
            //****************

            /*
            //The first list
            int[] s1 = {0, 2, 4, 6, 8 , 10};
            List<int> s1_List = new List<int>(s1);
            Console.WriteLine("Here is the first list");
            foreach(int s1_item in s1_List)
            {
                Console.Write(s1_item + " ");
            }
            Console.WriteLine();
            //The second list
            int[] s2 = new int[2];
            Random rnd = new Random();
            for(int i = 0; i < s2.Length; i++)
            {
                s2[i] = rnd.Next(0, 11);
            }
            List<int> s2_List = new List<int>(s2);
            Console.WriteLine("Here is the second list");
            foreach (int s2_item in s2_List)
            {
                Console.Write(s2_item + " ");
            }
            //is s2_List in s1_List?
            Console.WriteLine("Are List 2 elements present in List 1?");
            int yes_no = 0;
            for(int i = 0; i < s2_List.Count; i++)
            {
                if(s1_List.Contains(s2_List[i]))
                {
                    yes_no++;
                }
            }
            if (yes_no == s2_List.Count)
            {
                Console.WriteLine("Answer: yes");
            }
            else Console.WriteLine("Answer: no");
            */

            //***Day5 Task6***
            //****************

            /*
            //Possible RNA bases
            List<string> rnaBases = new List<string> {"A", "U", "G", "C"};
            //Generating a random RNA sequence of ten members
            Random rnd = new Random();
            List<string> rnaSeq = new List<string>();
            for(int i = 0; i < 10; i++)
            {
                rnaSeq.Add(rnaBases[rnd.Next(rnaBases.Count)]);
            }
            Console.WriteLine("Random RNA sequence:");
            foreach (string bases in rnaSeq)
            {
                Console.Write(bases + " ");
            }
            Console.WriteLine();
            //Translating RNA to DNA
            List<string> dnaSeq = new List<string>();
            string toCompare;
            for(int d = 0; d < rnaSeq.Count; d++)
            {
                toCompare = rnaSeq[d];
                switch(toCompare)
                {
                    case "A":
                        dnaSeq.Add("A - T");
                        break;
                    case "U":
                        dnaSeq.Add("T - A");
                        break;
                    case "G":
                        dnaSeq.Add("G - C");
                        break;
                    case "C":
                        dnaSeq.Add("C - G");
                        break;
                }
            }
            Console.WriteLine("RNA was translated to DNA:");
            foreach (string s in dnaSeq)
            {
                Console.WriteLine(s);
            }
            */

            //***Day5 Task7***
            //****************

            /*
            //Generating a long list
            List<int> intList = new List<int>();
            Random rnd = new Random();
            for(int i = 0; i < 1E6; i++)
            {
                intList.Add(rnd.Next(10));
            }
            //Initiating the watch
            var watch = System.Diagnostics.Stopwatch.StartNew();
            //Sorting the list
            intList.Sort();
            //Starting the watch
            watch.Start();
            //Counting ms
            var msCount = watch.ElapsedMilliseconds;
            Console.WriteLine("It took {0} ms to sort the list", msCount);
            watch.Stop();
            */

            //***Day5 Task8***
            //****************

            /*
            //Initiating the reading of all lines of the file and saving to a string array
            string[] interArray = File.ReadAllLines("C:\\Users\\mangri\\Desktop\\.NET\\countries.txt");
            //Copying the array content into internal List
            List<string> interList = new List<string>(interArray);
            //Sorting the list
            interList.Sort();
            //Copying the sorted list into another file
            File.WriteAllLinesAsync("C:\\Users\\mangri\\Desktop\\.NET\\countries_sorted.txt", interList);
            */

            //***Day5 Task9***
            //****************

            /*
            //Making matrix manually
            int[,] matrix = new int[,] { { 1, 2, 3}, { 4, 5, 6}, { 7, 8, 9} };
            //The sum of all the elements
            int sum = matrix.Cast<int>().ToArray().Sum();
            Console.WriteLine("The sum of all the matrix elements: " + sum);
            //Sum of each row
            Console.Write("The sum for each row: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum = sum + matrix[i, j];
                }
                Console.Write(sum + " ");
            }
            Console.WriteLine();
            //Sum of each column
            Console.Write("The sum for each column: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum = sum + matrix[j, i];
                }
                Console.Write(sum + " ");
            }
            Console.WriteLine();
            */

            //***Day5 Task10***
            //****************

            /*
            //Creating an integer array amnually
            int[] skMasyvas = { 1, 20, 15, 99, 55, 23, 0, 99, 21 };
            Console.WriteLine("Initial array: ");
            foreach (int sk in skMasyvas)
            {
                Console.Write(sk + " ");
            }
            Console.WriteLine();
            //Sorting algorithm
            int tempor;
            for (int m = 0; m < skMasyvas.Length; m++)
            {
                for (int n = m; n < skMasyvas.Length; n++)
                {
                    if (skMasyvas[n] < skMasyvas[m])
                    {
                        tempor = skMasyvas[m];
                        skMasyvas[m] = skMasyvas[n];
                        skMasyvas[n] = tempor;
                    }
                }
            }
            Console.WriteLine("Sorted array: ");
            foreach (int skSorted in skMasyvas)
            {
                Console.Write(skSorted + " ");
            }
            */

        }
    }
}
