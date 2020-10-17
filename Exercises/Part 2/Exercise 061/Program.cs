using System;

namespace exercise_61
{
  class Program
  {
    public static void Main(String[] args)
    {
     
            PrintRightTriangle(4);
            ChristmasTree(10);


            Console.ReadKey();

    }

    public static void PrintStars(int number)
    {
                        for(int i = 0; i <= number; i++){
            Console.Write("*");

            }

    }

    public static void PrintSpaces(int number)
    {
            for(int i = 0; i <= number; i++){
            Console.Write(" ");

            }

            

    }

    public static void PrintRightTriangle(int size)
    {
       for (int i = 1; i <= size; i++) {  
            for (int j = 1; j <= size-i; j++) {  
                Console.Write(" ");  
            } for (int k = 1; k <= i; k++) {  
               Console.Write("*");  
            }  
            Console.WriteLine("");  
         }  
     }

    public static void ChristmasTree(int height)
    {
        for(int i = 1; i <= height; i++){
                           
             for (int k = height-i; k>=0; k--) {
                PrintSpaces(0);
                        }
             for (int j=1+(i-1)*2; j>0; j--){
                PrintStars(0);
                        }
             Console.WriteLine("");
        }

        for (int n = 0; n <= 1; n++){
            
            for(int m = 0; m <= height-2; m++){
            Console.Write(" ");
                    }
            Console.WriteLine("***");

            }

        
    }
  }
}
