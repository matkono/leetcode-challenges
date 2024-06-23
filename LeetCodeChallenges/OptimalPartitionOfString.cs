namespace Resolved;


// Link to challenge:https://leetcode.com/problems/optimal-partition-of-string/description/
public class OptimalPartitionOfString
{
    private string _originalString { get; set; }

    public void CalculateSubstringsAmout() 
    {
        GetInput();

        var hashSet = new HashSet<char>();
        var subStringAmount = 1;

        foreach (var character in _originalString)
        {
            if (hashSet.Contains(character))
            {
                hashSet.Clear();
                subStringAmount++;
            }
            hashSet.Add(character);
        }

        Console.WriteLine($"The substring amount of string {_originalString} is {subStringAmount}");
    }

    public void GetInput()
    {
        Console.WriteLine("Digit the string to check: ");
        _originalString = Console.ReadLine()!;
    }
}
