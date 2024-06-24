namespace Resolved;

// Link to challenge:https://leetcode.com/problems/check-if-number-has-equal-digit-count-and-digit-value/description/
public class CheckIfNumberHasEqualDigitCountAndDigitValue
{
    private string Number { get; set; }

    public void Check() 
    {
        GetInput();
        
        var validate = Number.Select((character, index) =>
            Number.Count(x => 
                int.Parse(x.ToString()).Equals(index)) == int.Parse(character.ToString())
            ).All(result => result);

        if (validate)
            Console.WriteLine($"The condition holds true for every index in {Number}.");
        else
            Console.WriteLine($"The condition doesn't holds true for every index in {Number}.");
    }

    public void GetInput() 
    {
        Console.WriteLine("Digit the number to check: ");
        Number = Console.ReadLine()!;
    }
}
