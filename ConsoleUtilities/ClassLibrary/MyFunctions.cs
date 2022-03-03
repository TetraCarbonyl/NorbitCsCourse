using System;

namespace ClassLibrary
{
    public class MyFunctions
    {
        public string StringFrom1toN(int N)
        {
            string OutputString = null;

            for (int i = 1; i <= N; i++)
            {
                OutputString += i.ToString();

                if (i != N)
                {
                    OutputString += ',';
                }
            }
            return OutputString;
        }

        public void RectangleAsterix(int N)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if ((i != j) || (i != (N - 1) / 2))
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.Write('\n');
            }
        }
    }
}
