﻿using System;

namespace exercise_60
{
  class Program
  {
        public static void Main(String[] args)
    {
              PrintStars(5);
              PrintSquare(4);
              PrintRectangle(17, 3);
              PrintTriangle(4);



            Console.ReadKey();

    }


    public static void PrintStars(int number)
    {
            for(int i = 0; i <= number; i++){
            Console.Write("*");

            }

            Console.WriteLine("");
                      
      // you can print one star with the command
      // Console.Write("*");
      // call the print command n times
      // in the end print a line break with the comand
      // Console.WriteLine("");
    }

    public static void PrintSquare(int size)
    {
            for (int i = 0; i <= size; i++){
                for(int j = 0; j <=size; j++){
                Console.Write("*");
                }
                Console.WriteLine("");
                            
            }

    }

    public static void PrintRectangle(int width, int height)
    {
            for (int i = 0; i <= height; i++){
                for(int j = 0; j <=width; j++){
                Console.Write("*");
                }
                Console.WriteLine("");
                            
            }

    }

    public static void PrintTriangle(int size)
    {
        for (int i = 1; i <= size; i++) {  
            for (int j = 1; j <= i; j++) {  
               Console.Write("*");  
            }  
            Console.WriteLine("");  
         }  

    }
  }
}
