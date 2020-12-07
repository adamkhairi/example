namespace example
{
    public class Personne
    {
        public string name;
        public int age;
        private int refr;
        private int rating;

        public Personne(string name, int age, int refr, int rating)
        {
            this.name = name;
            this.age = age;
            this.refr = refr;
            this.rating = rating;
        }

        public int Refr
        {
            get { return refr; }
            set
            {
                if (value >= 10 || value <= 1)
                {
                    refr = value;
                }
                else
                {
                    refr = 1;
                }
            }
        }

        public int Rating
        {
            get { return rating; }
            set
            {
                if (value >= 5 || value <= 0)
                {
                    rating = value;
                }
                else
                {
                    rating = 0;
                }
            }
        }
    }
}