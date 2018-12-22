using System;
using System.Collections.Generic;
using System.Linq;

namespace Day1
{
  class Program
  {
    static void Main(string[] args)
    {
      var input = System.IO.File.ReadAllLines(@"C:\Users\Administrator\Documents\Visual Studio 2017\Projects\AdventOfCode2018\Day1\input.txt")
        .Where(x => !string.IsNullOrWhiteSpace(x))
        .Select(x => int.Parse(x));

      PartOne(input);
      PartTwo(input);

      Console.ReadLine();
    }

    private static void PartOne(IEnumerable<int> input)
    {
      int sum = 0;

      foreach (int i in input)
      {
        sum += i;
      }

      Console.WriteLine($"Part one: {sum}");
    }

    private static void PartTwo(IEnumerable<int> input)
    {
      int currentFreq = 0;
      bool done = false;
      HashSet<int> hs = new HashSet<int>();

      while (!done)
      {
        foreach (int i in input)
        {
          currentFreq += i;
          if (!hs.Contains(currentFreq))
          {
            hs.Add(currentFreq);
          }
          else
          {
            Console.WriteLine($"Part two: {currentFreq}");
            done = true;
            break;
          }
        }
      }
    }
  }
}
