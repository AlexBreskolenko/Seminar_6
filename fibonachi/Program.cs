//Числа фибоначи

int Fibonacci(int n)
{
    if (n == 1 || n == 2)
    {
        return 1;
    }
    else
    {
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}

//Выводим первые 10 чисел фибоначи
for(int i = 1; i < 10; i++)
{
    Console.Write($"{Fibonacci(i)} ");
}