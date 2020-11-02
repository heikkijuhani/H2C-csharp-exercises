using System;
using Exercise_121;

namespace exercise_121
{
  class Program
  {
    public static void Main(string[] args)
    {
      Fitbyte assistant = new Fitbyte(37, 60);
      double percentage = 0.5;

      while (percentage < 1.0)
      {
        double target = assistant.TargetHeartRate(percentage);
        Console.WriteLine("Target " + (percentage * 100) + "% of maximum: " + target);
        percentage = percentage + 0.1;
      }

            Console.ReadKey();
    }
  }
}
