using System;

public class NumbersOFArraysSorting {
        public static void SortingOfArray(int[] numbers){
        int i = 0;
        while(i<numbers.Length){
                int correctIndex = numbers[i] -1;

                if(numbers[i] != numbers[correctIndex]){
                        int temp = numbers[i];
                        numbers[i] = numbers[correctIndex];;
                        numbers[correctIndex] = temp;       
                }
                else{
                        i++;
                }
        }
}
    public static void Main(string[] args) {
        int[] numbers = { 7, 9, 8, 2, 5, 1, 6, 3, 4 };
        SortingOfArray(numbers);
        Console.WriteLine(string.Join(" ", numbers));
  }
}