using System.Collections.Generic;
using System;
using System.Linq;

public class GradeRegister
{
  private List<int> grades;
  private List<int> pointsList;

  public GradeRegister()
  {
    this.grades = new List<int>();
    this.pointsList = new List<int>();
  }

  public void AddGradeBasedOnPoints(int points)
  {
    this.grades.Add(PointsToGrades(points));
    this.pointsList.Add(points);
  }

  public int NumberOfGrades(int grade)
  {
    int count = 0;
    foreach (int received in this.grades)
    {
      if (received == grade)
      {
        count++;
      }
    }
    return count;
  }

  public static int PointsToGrades(int points)
  {
    int grade = 0;
    if (points < 50)
    {
      grade = 0;
    }
    else if (points < 60)
    {
      grade = 1;
    }
    else if (points < 70)
    {
      grade = 2;
    }
    else if (points < 80)
    {
      grade = 3;
    }
    else if (points < 90)
    {
      grade = 4;
    }
    else
    {
      grade = 5;
    }
    return grade;
  }

  public double AverageOfGrades()
  {
        // Hint! You don't need to round the -1, but you do need it for all the other results...
        if (this.grades.Count == 0)
        {
            return Math.Round(-1.0, 2);

        } else { 
        double average;
        double count = this.grades.Count;
        double sum = this.grades.Sum();

        average = (sum * 1.0) / (count * 1.0);
        double roundAverage = Math.Round(average, 2);

        return roundAverage;
        }
    }

  public double AverageOfPoints()
  {
        if(this.pointsList.Count == 0)
        {
            return Math.Round(-1.0, 2);
        } else
        {
            double average;
            double count = this.pointsList.Count;
            double sum = this.pointsList.Sum();

            average = (sum * 1.0) / (count * 1.0);
            double roundAverage = Math.Round(average, 2);

            return roundAverage;

        }
        


    
  }
}
