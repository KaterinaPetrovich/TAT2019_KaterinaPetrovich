using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Triangle
{
    /// <summary>
    /// Abstract class Builder.
    /// </summary>
    abstract class Builder
    {
        protected Builder builder;
        public Builder(Builder builder)
        {
            this.builder = builder;
        }

        /// <summary>
        /// Method for definition triagle and create triangle
        /// </summary>
        /// <param name="point1">first treagle's point</param>
        /// <param name="point2">second treagle's point</param>
        /// <param name="point3">third treagle's point</param>
        /// <returns>Return triangle</returns>
        public abstract Triangle Create(Point point1, Point point2, Point point3);
    }
}
