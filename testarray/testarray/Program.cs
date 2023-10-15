#region testarray
//int[] numbers = { 23, 14, 2, 5, 16 };
//int result = 1;
////Array.Sort(numbers);
//foreach (var number in numbers)
//{
//    if (number<=20 && number>=1)
//        result*= number;
//    }
//Console.WriteLine(result);

#endregion

#region task2
int[] numbers = { 3, 5, 6, 9, 14, 2, 16 };
int sum = 0;

foreach (int number in numbers)
{
	if (number % 2 == 0)
	{
		sum += number;
	}
}
Console.WriteLine(sum * sum);





#endregion