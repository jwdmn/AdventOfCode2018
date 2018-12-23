using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day2
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] input = System.IO.File.ReadAllLines(@"C:\Users\Administrator\Documents\Visual Studio 2017\Projects\AdventOfCode2018\Day2\input.txt");

      Console.WriteLine("PART ONE");
      PartOne(input);

      Console.WriteLine("\nPART TWO");
      PartTwo(input);
      Console.ReadLine();
    }

    private static void PartOne(string[] input)
    {
      int doubles = 0;
      int triplets = 0;

      foreach (string id in input)
      {
        var charOccurrences = id.GroupBy(c => c).Select(c => c.Count());

        if (charOccurrences.Any(d => d == 2))
        {
          doubles++;
        }
        if (charOccurrences.Any(t => t == 3))
        {
          triplets++;
        }
      }

      Console.WriteLine($"Doubles: {doubles}");
      Console.WriteLine($"Triplets: {triplets}");
      Console.WriteLine($"Checksum: {doubles * triplets}");
    }

    private static void PartTwo(string[] input)
    {
      var bar = input.OrderBy(c => c).ToArray();

      for (int i = 0; i < bar.Length - 1; i++)
      {
        int matches = 0;
        for (int j = 0; j < bar[i].Length; j++)
        {
          if (bar[i][j].Equals(bar[i + 1][j]))
          {
            matches++;
          }
        }

        if (matches == bar[i].Length - 1)
        {
          int removeAtIndex = 0;
          for (int k = 0; k < matches + 1; k++)
          {
            if (bar[i][k] != bar[i + 1][k])
            {
              removeAtIndex = k;
            }
          }

          StringBuilder sb = new StringBuilder(bar[i]).Remove(removeAtIndex, 1);
          Console.WriteLine(sb);
        }
      }
    }
  }
}
