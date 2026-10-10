public class MoveNegativeNumberLeftSide{

    public static void Rotate(int[] numbers)
{
     int left =0;
     int right = numbers.Length - 1;
        while (left < right)
        {
            if (numbers[left] < 0)
            {
                left++;
            }
            else if (numbers[right] >= 0)
            {
                right--;
            }
            else
            {
                int temp = numbers[left];
                numbers[left] = numbers[right];
                numbers[right] = temp;
                left++;
                right--;
            }
    }
}
    public static void Main(string[] args)
    {
        int [] numbers = {1, -2, 3, -4, 5, -6, 7, -8};
        Rotate(numbers);
        for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    }
}