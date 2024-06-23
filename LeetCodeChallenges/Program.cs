using Resolved;

var shouldContinueExecuting = true;
while (shouldContinueExecuting) 
{
    Console.WriteLine("Digit the challenge solution:");
    Console.WriteLine("1 - TwoSum");

    var option = int.Parse(Console.ReadLine()!.ToString());
    switch (option) 
    {
        case 1:
            var twoSum = new TwoSum();
            twoSum.Calculate();
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