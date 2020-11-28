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

        public override bool Equals(object compared)
        {
            //compare with Item.identifier

            if (this == compared)
            {
                return true;
            }



            if ((compared == null) || !this.GetType().Equals(compared.GetType()))

            {
                return false;
            }



            Book comparedItem = (Book)compared;


            if (this.name == comparedItem.name && this.publicationYear == comparedItem.publicationYear)

            {

                return true;

            }

            return false;
        }
    }
}
