var input1 = Console.ReadLine();
var input2 = Console.ReadLine();

int num1 = System.Convert.ToInt32(input1);
int num2 = System.Convert.ToInt32(input2);

Func<int, int,(int, int, int,int,int)> calc = (x, y) => (x+y,x-y,x*y,x/y,x%y);
Console.WriteLine(calc(num1,num2));
