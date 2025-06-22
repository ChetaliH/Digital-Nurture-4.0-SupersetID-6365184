namespace MyProject;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nRecursion is a method where a function calls itself to solve smaller instances of a problem,\nsimplifying complex tasks like factorials or financial predictions.");
        double growthRate = 0.1;
        int year = 5;
        double initialValue = 100000;

        Prediction predictor = new Prediction();
        double result = predictor.CompoundGrowth(year, initialValue, growthRate);
        Console.WriteLine($"\nThe forecast for {year} years is: " + result);

        //Time Complexity Analysis=>
        Console.WriteLine("\nThe CompoundGrowth function runs O(N) times, where N is the number of years.");
        Console.WriteLine("\nThis recursion is optimal only because it depends on one previous result.");
        Console.WriteLine("\nFor over-lapping sub-problems, we must use memoization or choose iterative approach.\n");


    }
}

class Prediction
{
    public double CompoundGrowth(int year, double initialValue, double growthRate)
    {
        if (year == 0)
        {
            return initialValue;
        }
        return CompoundGrowth(year - 1, initialValue, growthRate) * (1 + growthRate);
    }
}
