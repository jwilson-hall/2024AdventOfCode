using Xunit.Abstractions;

namespace _2024AdventOfCode;

public class UnitTest1(ITestOutputHelper output)
{
    [Fact]
    public void Day1()
    {
        var day1 = new Day1();
        var input = day1.LoadData();

        int answer1 = day1.CalculateAnswerPart1(input);
        output.WriteLine($"Day 1 Part 1: {answer1}");
        Assert.Equal(765748, answer1 );

        input = day1.LoadData();
        int answer2 = day1.CalculateAnswerPart2(input);
        output.WriteLine($"Day 1 Part 2: {answer2}");
        Assert.Equal(27732508, answer2);
    }
    [Fact]
    public void Day2()
    {
        var day2 = new Day2();
        var input = day2.LoadData();

        //int answer = day2.TotalDistance(input);
        //output.WriteLine($"Day 2: {answer}");
    }
} 