namespace Lesson3
{
    internal class Homework
    {
        static void Homework1()
        {
            int x = 5;
            int y = 2;
            int sum = 0;

            if (x == y)
            {
                Console.WriteLine(x);
            }

            else if (x < y)
            {
                for (int i = x; i <= y; i++)
                {
                    sum = sum + i;
                }
                Console.WriteLine(sum);
            }

            else
            {
                for (int i = y; i <= x; i++)
                {
                    sum = sum + i;
                }
                Console.WriteLine(sum);
            }
        }
    }
}
