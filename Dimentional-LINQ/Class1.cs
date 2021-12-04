namespace Dimentional_LINQ
{
    public static class Class1
    {
        public static int[,] Where(this int[,] e, Func<int, int, bool> c)
        {
            int[,] r = e;
            for (int i = 0; i < e.GetLength(0); i++)
            {
                for (int j = 0; j < e.GetLength(1); j++)
                {
                    if (!c(i, j))
                    {
                        r[i, j] = 0;
                    }
                }
            }

            return r;
        }
    }
}