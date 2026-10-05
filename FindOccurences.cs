class FindOccurences
{
        public static void Find(int[] numbers, int k)
    {
        int count = 0;
        for(int i = 0; i< numbers.Length ; i++)
        {
            if(numbers[i] == k)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
    public static void Main(string[] args)
    {
        int[] numbers = {1,2,3,1,2,3,4,5,3,2,4};
        int k = 1;
        Find(numbers, k);
    }

}