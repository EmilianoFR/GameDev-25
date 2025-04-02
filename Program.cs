// See https://aka.ms/new-console-template for more information


var active = ("y");
while (active == ("y"))
{Console.WriteLine("Enter first number to be averaged:  ");
    int Var1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter second number to be averaged:  ");
    int Var2 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter final number to be averaged:  ");
    int Var3 = int.Parse(Console.ReadLine());

int sum = Var1 + Var2 + Var3;
int avg = sum / 3;

    Console.WriteLine("Average is: " + avg);
    Console.WriteLine("Enter 'y' for to restart, or anything else to end: ");
    active = Console.ReadLine();
    
}