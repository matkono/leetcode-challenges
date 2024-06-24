using Resolved;

var shouldContinueExecuting = true;
while (shouldContinueExecuting)
{
    Console.WriteLine("Digit the challenge solution:");
    Console.WriteLine("1 - Two sum");
    Console.WriteLine("2 - Check if number has equal digit count and digit value");
    Console.WriteLine("3 - Optimal partition of string");
    Console.WriteLine("4 - Dijkstra algorithm");

    var option = int.Parse(Console.ReadLine()!.ToString());
    switch (option)
    {
        case 1:
            var twoSum = new TwoSum();
            twoSum.Calculate();
            break;

        case 2:
            var checkIfNumberHasEqualDigitCountAndDigitValue = new CheckIfNumberHasEqualDigitCountAndDigitValue();
            checkIfNumberHasEqualDigitCountAndDigitValue.Check();
            break;

        case 3:
            var optimalPartitionOfString = new OptimalPartitionOfString();
            optimalPartitionOfString.CalculateSubstringsAmout();
            break;

        case 4:
            var dijkstraAlgorithm = new DijkstraAlgorithm();
            dijkstraAlgorithm.FindShortestPath();
            break;

        default:
            Console.WriteLine("Option is invalid");
            break;
    }

    Console.WriteLine("Do you want to continue?");
    Console.WriteLine("Y - yes");
    Console.WriteLine("N - no");

    var answer = Console.ReadLine()!;
    if (answer.Equals("N"))
        shouldContinueExecuting = false;
}