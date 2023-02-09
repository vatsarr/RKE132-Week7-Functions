
Console.WriteLine("Enter the operator (+/-/*//):");
char userOperator = Char.Parse(Console.ReadLine());

Console.WriteLine("Enter first number:");
int firstNum = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter second number:");
int secondNum = Int32.Parse(Console.ReadLine());

switch (userOperator)
{
    default:
        Console.WriteLine("Invalid operator!");
        break;
    case '+':
        Addition(firstNum, secondNum);
        break;
    case '-':
        Subtraction(firstNum, secondNum);
        break;
    case '*':
        Multiply(firstNum, secondNum);
        break;
    case '/':
        Divide(firstNum, secondNum);
        break;
}

static void Addition(int a, int b)
{
    Console.WriteLine($"{a} + {b} = {a + b}");
};

static void Subtraction(int a, int b)
{
    Console.WriteLine($"{a} - {b} = {a - b}");
}

static void Multiply(int a, int b)
{
    Console.WriteLine($"{a} * {b} = {a * b}");
}

static void Divide(int a, int b)
{
    Console.WriteLine($"{a} / {b} = {a / b}");
}