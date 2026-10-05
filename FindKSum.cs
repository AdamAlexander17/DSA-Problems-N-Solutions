class FindKSum
{

    public static void Find(int[] numbers, int target)
    {
        int left = 0;
        int right = numbers.Length - 1;
        while (left < right){
            int sum = numbers[left] + numbers[right];
            if (sum == target){
                Console.WriteLine($"Pair found: ({numbers[left]}, {numbers[right]} )");
                left++;
                right--;
            }
            else if (sum < target){
                left++;
            }
            else{
                right--;
            }
            
        }
    }
    public static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int target = 10;
        Find(numbers, target);
    }
}