using Xunit.Abstractions;

namespace _2024AdventOfCode;

public class UnitTest1(ITestOutputHelper output)
{
    [Fact]
    public void Day1()
    {
        var puzzle = new Day1();
        var input = puzzle.LoadData();

        int answer1 = puzzle.CalculateAnswerPart1(input);
        output.WriteLine($"Day 1 Part 1: {answer1}");
        Assert.Equal(765748, answer1 );

        input = puzzle.LoadData();
        int answer2 = puzzle.CalculateAnswerPart2(input);
        output.WriteLine($"Day 1 Part 2: {answer2}");
        Assert.Equal(27732508, answer2);
    }
    [Fact]
    public void Day2()
    {
        var puzzle = new Day2();
        var input = puzzle.LoadData();

        int answer1 = puzzle.CalculateAnswerPart1(input);
        output.WriteLine($"Day 2 Part 1: {answer1}");
        Assert.Equal(463, answer1);

        input = puzzle.LoadData();
        int answer2 = puzzle.CalculateAnswerPart2(input);
        output.WriteLine($"Day 2 Part 2: {answer2}");

    }
} 