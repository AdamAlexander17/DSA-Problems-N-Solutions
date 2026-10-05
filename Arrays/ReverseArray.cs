class ReverseArray
{
    public static void Reverse(int[] numbers)
    {
        int left = 0;
        int right = numbers.Length -1;
        while (left < right)
        {
            int temp = numbers[left];
            numbers[left] = numbers[right];
            numbers[right] = temp;
            left++;
            right--;
        }
    }
    public static void Main(string[] args)
    {
        int [] numbers = {1,2,3,4,5};
        Reverse(numbers);
        Console.WriteLine(string.Join(", ", numbers));
    
    }
}