public static class ReverseString
{

    public static string Reverse(string input)
    {
        char [] chracter = input.ToCharArray();
        int left = 0;
        int right = chracter.Length -1 ;
        while (left < right)
        {
            char temp = chracter[left];
            chracter[left] = chracter[right];
            chracter[right] = temp;
            left++;
            right--;
        }
        return new string(chracter);
    }
    public static void Main(string[] args)
    {
        string input = "Mohammed";
        string result = Reverse(input);
        Console.WriteLine(result);
    }
}