using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024AdventOfCode;
internal class Day1
{
    public Day1Object LoadData()
    {
        Day1Object day1Object = new Day1Object();
        foreach (string line in File.ReadLines("../../../Day1Input.txt"))
        {
            string[] parts = line.Split("   ");
            day1Object.Left.Add(int.Parse(parts[0]));
            day1Object.Right.Add(int.Parse(parts[1]));
        }
        return day1Object;
    }

    public int CalculateAnswerPart1(Day1Object day1Object)
    {
        int totalDistance = 0;
        if (day1Object.Left.Count != day1Object.Right.Count)
        {
            throw new Exception("Left and Right lists are not the same length");
        }

        day1Object.Left.Sort();
        day1Object.Right.Sort();

        for (int i = 0; i < day1Object.Left.Count; i++)
        {
            totalDistance += Math.Abs(day1Object.Left[i] - day1Object.Right[i]);
        }

        return totalDistance;
    }

    public int CalculateAnswerPart2(Day1Object day1Object)
    {
        Dictionary<int, int> leftDictionary = new Dictionary<int, int>();
        foreach (int number in day1Object.Left)
        {
            if (!leftDictionary.ContainsKey(number))
            {
                leftDictionary[number] = 0;
            }
        }
        foreach (int number in day1Object.Right)
        {
            if (leftDictionary.ContainsKey(number))
            {
                leftDictionary[number]++;
            }
        }
        int similarity = 0;
        foreach (int key in leftDictionary.Keys)
        {
            similarity += key * leftDictionary[key];
        }
        return similarity;
    }
}
public class Day1Object
{
    public List<int> Left { get; set; } = [];
    public List<int> Right { get; set; } = [];
}
