public class Practice
{
    public static int Find(int[] numbers)
    {
        int left = 1;
        for(int right = 1 ; right<numbers.Length; right++)
        {
            if(numbers[right] != numbers[right-1])
            {
                numbers[left] = numbers[right];
                left++;
            }
        } 
        return left;
    }

    public static void Main(string[] args)
    {
       int[] numbers = {1,1,2,3,3,4,5,6,3,4,6,5,7,8,9};
       Array.Sort(numbers);
       int result = Find(numbers);
       for(int i = 0; i < result; i++)
       {
           System.Console.Write(numbers[i] + " ");
       }

    }
}