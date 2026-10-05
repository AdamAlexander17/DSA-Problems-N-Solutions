class SecondLargest
{
    public static void Find(int[] numbers)
    {
       int largest = numbers[0];
       int secondLargest = numbers[0];

       for(int i = 0; i < numbers.Length; i++)
        {
            if(numbers[i] > largest)
            {
                secondLargest = largest;
                largest = numbers[i];
            }
            else if(numbers[i] > secondLargest && numbers[i] != largest)
            {
                secondLargest = numbers[i];
            }
        }
        Console.WriteLine("Second Largest: " + secondLargest);
    }
    public static void Main(string[] args)
    {
        int[] numbers = {22,33,44,76, 89, 76, 54 , 90, 87 , 97};
        Find(numbers);
        Console.WriteLine(string.Join(", ", numbers));

    }
}