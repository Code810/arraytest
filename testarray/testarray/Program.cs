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
//int[] numbers = { 3, 5, 6, 9, 14, 2, 16 };
//int sum = 0;

//foreach (int number in numbers)
//{
//	if (number % 2 == 0)
//	{
//		sum += number;
//	}
//}
//Console.WriteLine(sum * sum);


#endregion

#region task3
//int n = int.Parse(Console.ReadLine());
//int m = int.Parse(Console.ReadLine());
//if (n % 2 == 0 && m % 2 == 0)
//{
//    Console.WriteLine(n + m);
//}
//else
//{
//    Console.WriteLine( "ededlerden biri ve ya her ikisi cut deyil");
//}
#endregion
#region task4
//int num = int.Parse(Console.ReadLine());
//int sum = 1;

//for (int i = 1; i <= num; i++)
//{
//    sum *= i;
//}
//Console.WriteLine(sum);

#endregion

#region task5

using System.Threading.Channels;
Console.WriteLine("Skafin olculerini daxil edin");
Console.Write("eni:");
int eni = int.Parse(Console.ReadLine());
Console.Write("hundurluyu:");
int hundurluk = int.Parse(Console.ReadLine());
Console.Write("uzunluq:");
int uzunluq = int.Parse(Console.ReadLine());

int e = 100;
int h = 200;

if ((eni<=e && hundurluk<=h) || (eni <= e && uzunluq <= h) || (uzunluq <= e && hundurluk <= h) || (uzunluq <= e && eni <= h)
    || (hundurluk <= e && uzunluq <= h)|| (hundurluk <= e && eni <= h)
    )
{
    Console.WriteLine("skaf qapidan kecir");
}

else
{
    Console.WriteLine("skaf qapidan kecmir");

}
#endregion