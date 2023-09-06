int number = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int nDigit = (int)(number / Math.Pow(10, n - 1) % 10);

if (number.ToString().Length < n) Console.WriteLine("-");
else Console.WriteLine(nDigit);