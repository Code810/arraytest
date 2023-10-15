#region testarray
int[] numbers = { 23, 14, 2, 5, 16 };
int result = 1;
//Array.Sort(numbers);
foreach (var number in numbers)
{
    if (number<=20 && number>=1)
        result*= number;
    }
Console.WriteLine(result);

#endregion