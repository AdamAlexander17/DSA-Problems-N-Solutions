class RemoveDuplicate
{
    public static int RemoveDup(int[] numbers)
    {
        int left = 1;
        for(int right = 1; right<numbers.Length; right++)
        {
            if(numbers[right] != numbers[right - 1])
            {
                numbers[left] = numbers[right];
                left++;
            }
        }
        return left;
        
    }
    public static void Main(string[] args)
    {
        int [] numbers = {1,1,2,3,3,4,5,6,3,4,6,5,7,8,9};
        Array.Sort(numbers);
        int uniqueVal = RemoveDup(numbers);
        for(int i = 0; i < uniqueVal; i++)
        {
            Console.Write(numbers[i] + " ");
        }

    }
}