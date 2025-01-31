
namespace Evennumbers
{
    //? Q:2 --- Even Numbers Code 
    class EvenNumbers
    {
        public static void Calculating()
        {
            Console.Clear();
            Console.Write("Enter Starting Point: ");
            int startPoint = int.Parse(Console.ReadLine());

            Console.Write("Enter End Point: ");
            int endPoint = int.Parse(Console.ReadLine());

            for (int i = startPoint; i <= endPoint; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("{0},", i);

                }
            }
            Console.WriteLine();
        }
    }
}



