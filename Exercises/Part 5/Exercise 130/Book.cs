using System;

namespace exercise_130
{


  public class Book
  {

    private string name;
    private int publicationYear;

    public Book(string name, int publicationYear)
    {
      this.name = name;
      this.publicationYear = publicationYear;
    }


    // BEGIN SOLUTION
    public override bool Equals(object compared)
    {
      if (this.Equals(compared))
            {
                return true;

            } else
            {
                return false;
            }

      
    }
    // END SOLUTION
  }


}