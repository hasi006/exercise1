using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiersCL
{
    /// <summary>
    /// Same customer class use CL for illstration of different class library
    /// </summary>
    public class CustomerCL
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
        protected internal int CalculateRating(bool offer)
        {
            return 0;
        }
    }
}
