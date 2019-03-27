using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_4
{
    /// <summary>
    /// abstract class from which are inherited classes lecture, seminar and laboratory work
    /// </summary>
    abstract class Material
    {
        protected string description;
        private Guid guid;
        /// <summary>
        /// constructor generates guid
        /// </summary>
        public Material()
        {
            guid = Guid.NewGuid();
        }
        /// <summary>
        /// method returns guid
        /// </summary>
        /// <returns>guid</returns>
        public Guid GetGuid()
        {
            return guid;
        }
        /// <summary>
        /// overriden method 
        /// </summary>
        /// <returns>description</returns>
        public override string ToString()
        {
            return this.description;
        }
        /// <summary>
        /// overriden method 
        /// </summary>
        /// <param name="obj">object with compare</param>
        /// <returns>true if objects are the same</returns>
        public override bool Equals(object obj)
        {
            if (obj is Material)
            {
                var material = (Material)obj;
                return (this.guid == material.guid);
            }
            else
            {
                return false;
            }
        }


    }
}
