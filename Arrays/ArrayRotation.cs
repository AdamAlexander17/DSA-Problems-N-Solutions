class Rotate
{
    public static void RotateArray(int[] nums, int k){
        k = k%nums.Length;
        Reverse(nums, 0, nums.Length - 1);
        Reverse(nums, 0, k - 1);
        Reverse(nums, k, nums.Length - 1);
    }

    public static void Reverse(int[] nums, int start, int end){
        while(start< end)
        {
            int temp = nums[start];
            nums[start] = nums[end];
            nums[end] = temp;
            start++;
            end--;
        }
    }
    public static void Main(String[] args){
        int[] numbers = {1, 2, 3, 4, 5};
        int k = 2;
        RotateArray(numbers, k);
        Console.WriteLine(string.Join(" , " , numbers));
    }
}