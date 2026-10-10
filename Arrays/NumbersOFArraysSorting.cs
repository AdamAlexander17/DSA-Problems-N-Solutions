using System;

public class NumbersOFArraysSorting {
        public static void SortingOfArray(int[] numbers)
    {
        int i = 0;
        while (i < numbers.Length)
        {
            int CorrectIndex = numbers[i]-1;
            if(numbers[i] != numbers[CorrectIndex])
            {
                int temp = numbers[i];
                numbers[i] = numbers[CorrectIndex];
                numbers[CorrectIndex] = temp;
            }
            else
            {
                i++;
            }
    }
}

    public static void Main(string[] args) {
        int[] numbers = { 7, 9, 8, 1, 2, 5, 6, 3, 4};
        SortingOfArray(numbers);
        Console.WriteLine(string.Join(" ", numbers));
    }
}