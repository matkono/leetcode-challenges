namespace Resolved;

// Link to challenge: https://leetcode.com/problems/two-sum/description/
public class TwoSum
{
    private List<int> Numbers { get; set; } = new List<int>();
    private List<int> Result { get; } = new List<int>();
    private int Target { get; set; }

    public void Calculate()
    {
        GetInput();

        var hashMap = new Dictionary<int, int>();
        var numbers = Numbers.ToArray();

        for (int index = 0; index < numbers.Length; index++)
        {
            var number = Numbers[index];
            if (hashMap.ContainsKey(number))
            {
                Result.Add(hashMap[number]);
                Result.Add(index);
            }
            else
            {
                if (!hashMap.ContainsKey(Target - number))
                    hashMap.Add(Target - number, index);
            }
        }

        PrintResult();
    }

    private void GetInput()
    {
        Console.WriteLine("Digit the target: ");
        Target = int.Parse(Console.ReadLine()!.ToString());

        Console.WriteLine("Digit the quantity numbers: ");
        var quantityNumbers = int.Parse(Console.ReadLine()!.ToString());
        for (var quantity = 1; quantity <= quantityNumbers; quantity++)
        {
            Console.WriteLine("Digit the number: ");
            Numbers.Add(int.Parse(Console.ReadLine()!.ToString()));
        }
    }

    private void PrintResult()
    {
        Console.WriteLine($"The index of elements to sum {Target} are: {Result[0]} and {Result[1]}");
    }
}
