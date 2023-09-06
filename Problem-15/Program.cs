int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
string product;

if (a < 0 && b > 0 && c > 0) product = "negative";
else if(b < 0 && a > 0 && c > 0) product = "negative";
else if(c < 0 && b > 0 && a > 0) product = "negative";
else if (a < 0 && b < 0 && c < 0) product = "negative";
else product = "positive";

Console.WriteLine(product);