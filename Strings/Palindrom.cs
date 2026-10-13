public class Palindrom
{   
    public static void CheckPalindrome(string input)
    {
        // char [] chars = input.ToCharArray();
        int left = 0;
        int right = input.Length -1;
        // while (left < right)
        // {
        //     char temp = chars[left];
        //     chars[left] = chars[right];
        //     chars[right] = temp;
        //     left++;
        //     right--;
        // }
        // string reversed = new string(chars);

        // if (input == reversed)
        // {
        //     Console.WriteLine("The string is a palindrome.");
        // }
        // else
        // {
        //     Console.WriteLine("The string is not a palindrome.");
        // }
        // }

        while (left < right)
        {
            if(input[left] != input[right])
            {
                Console.WriteLine("The string is not a palindrome.");
                return;
            }
            left++;
            right--;
        }
        Console.WriteLine("The string is a palindrome.");
    }


public static void Main(string[] args)
        {
            string input = "MADAM";
            CheckPalindrome(input);
        }
}     

