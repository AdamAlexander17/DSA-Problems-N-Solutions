using System;

public class FindTarget {
    public static int Find(int[] numbers, int target){
          int left = 0;
          int right = numbers.Length-1;
          while(left<=right){
              int mid = left+(right-left)/2;
              if(numbers[mid]==target){
                  return numbers[mid];
              }
              else if(numbers[mid]<target){
                  left = mid+1;
              }
              else{
                  right = mid-1;
            }
          }
        return -1;
    }
    public static void Main(string[] args) {
        int [] numbers  = {10,20,30,40,50,60,70};
        int result = Find(numbers,60);
        Console.WriteLine (result);
    }
}