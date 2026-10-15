using System;

class ReverseArrays{
public static void Reverse(int [] numbers){
    for(int i = 0; i<numbers.Length; i++){
        for(int j = 0 ; j<numbers.Length-1-i; j++){
            if(numbers[j]>numbers[j+1]){
                int temp = numbers[j];
                numbers[j] = numbers[j+1];
                numbers[j+1] = temp;
            }
        }
    }
}
    
public static void Main(){
    int [] numbers = {7,11,8,6,1,4,3,2};
    Reverse(numbers);
    for(int a = 0 ; a<numbers.Length; a++){
        Console.WriteLine(numbers[a]);
    }
    }
}