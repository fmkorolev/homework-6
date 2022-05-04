// Задача 41
/*
Console.Write("input numbers(use space button): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Кол-во элементов > 0: {count}");
*/

// Задача 43
/*
Console.Write("input k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("input b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("input k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("input b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());
 
 
var x = -(b1 - b2) / (k1 - k2);
var y = k1 * x + b1;
 
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
Console.WriteLine($"Пересечение в точке: ({x};{y})");
*/
// Задача 42

string NUMBERS(int num)
{
    string result = String.Empty;
    while (num > 0)
    {
        result += Convert.ToString((num % 2));
        num /= 2;
    }
    result = new string (result.Reverse().ToArray());
    return  result;
}
Console.Write("Input number to convert in NUMBERS: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Your number in the binary numeral system = {NUMBERS(num2)}");
