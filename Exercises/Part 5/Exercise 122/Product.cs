namespace exercise_122
{
  public class Product
  {
    // DO NOT TOUCH THESE VARIABLES
    private string name;
    private string location;
    private int weight;

        // CREATE YOUR CONSTRUCTORS HERE

        public Product(string name)
        {
            this.name = name;
            this.location = "self";
            this.weight = 1;
        }

        public Product(string name, string location)
        {
            this.location = location;
            this.name = name;
            this.weight = 1;
        }

        public Product(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
            this.location = "warehouse";
        }



    // DO NOT TOUCH THIS
        public override string ToString()
    {
      return $"{this.name} ({this.weight} kg) can be found from the {this.location}.";
    }
  }
}