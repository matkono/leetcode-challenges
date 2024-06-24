namespace Resolved;


// Link to challenge:https://leetcode.com/problems/optimal-partition-of-string/description/
public class OptimalPartitionOfString
{
    private string OriginalString { get; set; }

    public void CalculateSubstringsAmout() 
    {
        GetInput();

        var hashSet = new HashSet<char>();
        var subStringAmount = 1;

        foreach (var character in OriginalString)
        {
            if (hashSet.Contains(character))
            {
                hashSet.Clear();
                subStringAmount++;
            }
            hashSet.Add(character);
        }

        Console.WriteLine($"The substring amount of string {OriginalString} is {subStringAmount}");
    }

    public void GetInput()
    {
        Console.WriteLine("Digit the string to check: ");
        OriginalString = Console.ReadLine()!;
    }
}
