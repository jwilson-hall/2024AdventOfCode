using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024AdventOfCode;
internal class Day2
{
    public Day2Object LoadData()
    {
        Day2Object day2Object = new Day2Object();
        foreach (string line in File.ReadLines("../../../Day2Input.txt"))
        {
            var levels = line.Split(" ").Select(int.Parse).ToList();
            day2Object.reports.Add(levels);
        }
        return day2Object;
    }
    public int CalculateAnswerPart1(Day2Object day2Object)
    {
        int safeReportsCount = 0;
        foreach (List<int> item in day2Object.reports)
        {
            bool safeReport = true;
            bool directionIncrease = item[1] > item[0];
            for (int i = 0; i < item.Count-1; i++)
            {
                int diff = item[i] - item[i + 1];
                if (Math.Abs(diff) is > 3 or 0)
                {
                    safeReport = false;
                }
                if (directionIncrease && diff > 0)
                {
                    safeReport = false;
                }
                else if(!directionIncrease && diff < 0)
                {
                    safeReport = false;
                }
            }
            if (safeReport)
            {
                safeReportsCount++;
            }
        }
        return safeReportsCount;
    }

    public int CalculateAnswerPart2(Day2Object day2Object)
    {
        int safeReportsCount = 0;
        foreach (List<int> item in day2Object.reports)
        {
            bool safeReport = true;
            bool directionIncrease = item[1] > item[0];
            for (int i = 0; i < item.Count - 1; i++)
            {
                int diff = item[i] - item[i + 1];
                if (Math.Abs(diff) is > 3 or 0)
                {
                    safeReport = false;
                }
                if (directionIncrease && diff > 0)
                {
                    safeReport = false;
                }
                else if (!directionIncrease && diff < 0)
                {
                    safeReport = false;
                }
            }
            if (safeReport)
            {
                safeReportsCount++;
            }
            else
            {
                for (int i = 0; i < item.Count; i++)
                {
                    var tempItem = new List<int>(item);
                    tempItem.RemoveAt(i);
                    if (IsSafeReport(tempItem))
                    {
                        safeReportsCount++;
                        break;
                    }
                }
            }
        }
        return safeReportsCount;
    }

    private bool IsSafeReport(List<int> item)
    {
        if (item.Count < 2) return false;
        bool directionIncrease = item[1] > item[0];
        for (int i = 0; i < item.Count - 1; i++)
        {
            int diff = item[i] - item[i + 1];
            if (Math.Abs(diff) is > 3 or 0)
            {
                return false;
            }
            if (directionIncrease && diff > 0)
            {
                return false;
            }
            else if (!directionIncrease && diff < 0)
            {
                return false;
            }
        }
        return true;
    }
}

public class Day2Object 
{
    public List<List<int>> reports = new();
}
