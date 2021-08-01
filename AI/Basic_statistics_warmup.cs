using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {
    static void Main(String[] args) {
int n = int.Parse(Console.ReadLine());
        string[] all = Console.ReadLine().Split(' ');
        List<double> numbers = new List<double>();
        
        for (int i = 0; i < all.Length; i++)
        {
            numbers.Add(int.Parse(all[i]));
        }
        numbers.Sort();
        //
        double sum = 0.0;
        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
        }
        double avg = sum / numbers.Count;
        //

        double median = 0;
        if (numbers.Count % 2 != 0)
        {
            median= numbers[(numbers.Count-1)/2];
        }
        else
        {
            int a = numbers.Count / 2;
            int b = a - 1;
            median = (numbers[a] + numbers[b]) / 2;
        }


        double mode = numbers.GroupBy(i => i)
            .OrderByDescending(g => g.Count())
            .Select(g => g.Key)
            .First();
            
        //
        double sum_squared = 0.0;
        double sd = 0.0;
        for (int i = 0; i < numbers.Count; i++)
        {
            sum_squared += Math.Pow(numbers[i] - avg, 2);
        }

        sd = Math.Pow(sum_squared / numbers.Count, 0.5);

        double lower_confidence = avg - 1.96 * sd / Math.Pow(numbers.Count, 0.5);
        double upper_confidence = avg + 1.96 * sd / Math.Pow(numbers.Count, 0.5);
        
        Console.WriteLine(avg.ToString("0.0"));
        Console.WriteLine(median.ToString("0.0"));
        Console.WriteLine(mode.ToString());
        Console.WriteLine(sd.ToString("0.0"));
        Console.WriteLine(lower_confidence.ToString("0.0") + " " + upper_confidence.ToString("0.0"));
    }
}