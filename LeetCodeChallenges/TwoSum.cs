namespace Resolved;

// Link to challenge: https://leetcode.com/problems/two-sum/description/
public class TwoSum
{
    private List<int> _numbers { get; set; } = new List<int>();
    private List<int> _result { get; } = new List<int>();
    private int _target { get; set; }

    public void Calculate()
    {
        GetInput();

        var hashMap = new Dictionary<int, int>();
        var numbers = _numbers.ToArray();

        for (int index = 0; index < numbers.Length; index++)
        {
            var number = _numbers[index];
            if (hashMap.ContainsKey(number))
            {
                _result.Add(hashMap[number]);
                _result.Add(index);
            }
            else
            {
                if (!hashMap.ContainsKey(_target - number))
                    hashMap.Add(_target - number, index);
            }
        }

        PrintResult();
    }

    private void GetInput()
    {
        Console.WriteLine("Digit the target: ");
        _target = int.Parse(Console.ReadLine()!.ToString());

        Console.WriteLine("Digit the quantity numbers: ");
        var quantityNumbers = int.Parse(Console.ReadLine()!.ToString());
        for (var quantity = 1; quantity <= quantityNumbers; quantity++)
        {
            Console.WriteLine("Digit the number: ");
            _numbers.Add(int.Parse(Console.ReadLine()!.ToString()));
        }
    }

    private void PrintResult()
    {
        Console.WriteLine($"The index of elements to sum {_target} are: {_result[0]} and {_result[1]}");
    }
}
