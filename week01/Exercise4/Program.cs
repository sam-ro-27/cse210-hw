class Program
{
    static void Main()
    {
        List<int> numbers = [];
        Console.WriteLine("Enter numbers. Type 0 to stop.");

        while (true)
        {
            Console.Write("Enter a number: ");
            string userResponse = Console.ReadLine();
            int userNumber = int.Parse(userResponse);

            if (userNumber == 0)
            {
                break;
            }

            numbers.Add(userNumber);
        }

        Console.WriteLine("Numbers in the list:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers were entered.");
            return;
        }

        int sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }
        Console.WriteLine("Sum of the numbers in the list: " + sum);

        float average = (float)sum / numbers.Count;
        Console.WriteLine("Average of the numbers in the list: " + average);

        int max = numbers[0];
        foreach (int n in numbers)
        {
            if (n > max)
            {
                max = n;
            }
        }
        Console.WriteLine("Maximum number in the list: " + max);
    }
}