using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_105
{
  public class Statistics
  {

        

        public int count { get; set; }
        public int sum { get; set; }
    
    

        public Statistics()
    {
            // initialize the variables here
            
            List<int> statistics = new List<int>();
            sum = statistics.Sum();
            count = statistics.Count();
                     
        }

    public void AddNumber(int number)
    {
            count++;
            sum = sum + number;
             
    }

  }
}