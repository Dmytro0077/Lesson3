namespace Lesson3
{
    internal class HomeworkExtra
    {
        static void Main()
        {
            Console.WriteLine("Введіть х:");
            string? x1 = Console.ReadLine();

            Console.WriteLine("Введіть y:");
            string? y1 = Console.ReadLine();

            int sum = 0;    
                        
            bool resultx = int.TryParse(x1, out int x);
            bool resulty = int.TryParse(y1, out int y);
           
            if (resultx && resulty)
            {               
                if (x == y)
                {
                    Console.WriteLine($"Cума чисел між числами x та y включно = {x}");
                }

                else if (x < y)
                {
                    for (int i = x; i <= y; i++)
                    {
                        sum += i;
                    }
                    Console.WriteLine($"Cума чисел між числами x та y включно = {sum}");
                }

                else
                {
                    for (int i = y; i <= x; i++)
                    {
                        sum  += i;
                    }
                    Console.WriteLine($"Cума чисел між числами x та y включно = {sum}");
                }                
            }

            else
            {
                Console.WriteLine("Введено некоректні дані. Будь ласка, введіть коректні числа х та у.");               
            }            
        }
    }
}
