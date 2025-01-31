namespace TriangleStars
{
    class Stars
    {
        public static void StarsPrinting()
        {
            Console.Write("Enter Stars Starting Number: ");
            int startingNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter Stars Ending Number: ");
            int endingNumber = int.Parse(Console.ReadLine());


            for (int i = startingNumber; i <= endingNumber; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }


            for (int i = endingNumber - 1; i >= startingNumber; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

        }

    }
}