internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter the start number : ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Enter the end number : ");
        int end = int.Parse(Console.ReadLine());
        for (int i = start; i <= end; i++)
        {
            int count = 0;
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}