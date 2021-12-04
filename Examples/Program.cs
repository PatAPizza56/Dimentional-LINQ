using Dimentional_LINQ;

int[,] test = new int[5, 5];
int num = 1;
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        test[i, j] = num;
        num++;
    }
}

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.WriteLine(test[i, j]);
    }
}

test = test.Where((i, j) => test[i, j] % 2 == 0);

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.WriteLine(test[i, j]);
    }
}