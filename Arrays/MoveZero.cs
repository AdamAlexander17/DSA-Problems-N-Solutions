class MoveZero
{
   public static void MoveZer0(int[] number){
     int left = 0;
     for (int right = 0; right<number.Length; right++){
       if(number[right] != 0){
        int temp = number[left];
        number[left] = number[right];
        number[right] = temp;
        left++;
       }
     }
}
    public static void Main(String[] args){
        int [] numbers = {0,1,0,2,0,1,3,0, 8,0,3,0,};
        MoveZer0(numbers);
        Console.WriteLine(string.Join(" , " , numbers));

    }
}