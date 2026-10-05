class FindMinMax
{
    public static void Find(int[] numbers)
    {
        int Min = numbers[0];
        int MAx = numbers[0];
        for(int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > MAx)
            {
                MAx = numbers[i];
            }
            else if (numbers[i] < Min)
            {
                Min = numbers[i];
            }
        }
        Console.WriteLine(Min);
        Console.WriteLine(MAx);
    }
    public static void Main(string [] args)
    {
        int [] numbers = {1,2,3,4,5};
        Find(numbers);
    }
}