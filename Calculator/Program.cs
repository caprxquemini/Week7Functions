int a = 2048;
int b = 1024;

Add(a, b);
Subtract(a, b);
Multiply(a, b);
Divide(a, b);


static void Add(int x, int y)
{
    Console.WriteLine($"{x} + {y} = {x + y}");
}

static void Subtract(int x, int y)
{
    Console.WriteLine($"{x} - {y} = {x - y}");
}

static void Multiply(int x, int y)
{
    Console.WriteLine($"{x} * {y} = {x * y}");
}

static void Divide(int x, int y)
{
    Console.WriteLine($"{x} / {y} = {x / y}");
}