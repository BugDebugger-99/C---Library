namespace List
{
    class ListHandler
    {
        public static void ProcessList()
        {
            int[] list = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };

            Console.Write("Input Index (0-8): ");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int index) && index >= 0 && index < list.Length)
            {
                Console.WriteLine("Items from index " + index + ":");
                for (int i = index; i < list.Length; i++)
                {
                    Console.WriteLine(list[i]);
                }
            }
            else
            {
                Console.WriteLine("Input was not in the correct format or out of range. Program will exit.");
            }

        }

    }
}