using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace AdventOfCode2022.Solutions
{
    class Day1
    {
        public void calculateCalories(string[] lines)
        {
            int counter = 0;
            List<int> weights = new List<int>();

            foreach (string line in lines)
            {
                if (string.IsNullOrEmpty(line))
                {
                    weights.Add(counter);
                    counter = 0;
                }
                else
                {
                    counter += int.Parse(line);
                }

            }
            weights.Sort();

            int mostCalories = weights.Last();

            Console.WriteLine("The elf carrying most calories: {0}", mostCalories);
            Console.WriteLine("The three with most calories: {0}", mostCalories + weights[weights.Count - 2] + weights[weights.Count - 3]);

        }

    }
}
