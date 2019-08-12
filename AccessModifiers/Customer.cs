namespace AccessModifiers
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {

        }


        /// <summary>
        /// Method Can be accessible inside the class only
        /// </summary>
        /// <returns></returns>
        private int CalculateRating()
        {
            return 0;
        }

        /// <summary>
        /// Same calculate rating method illustration only
        /// </summary>
        /// <param name="offer"></param>
        /// <returns></returns>
        protected int CalculateRating(bool offer)
        {
            return 0;
        }
    }
}
