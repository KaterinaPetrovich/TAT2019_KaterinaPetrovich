using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_4
{
    /// <summary>
    /// class of laboratory work
    /// </summary>
    class LaboratoryWork:Material, ICloneable
    {
        /// <summary>
        /// constructor creates objects
        /// </summary>
        public LaboratoryWork()
        {
            description = "This is laboratory work";
        }
        /// <summary>
        /// method clones object of class  
        /// </summary>
        /// <returns>cloned object</returns>
        public object Clone()
        {
            LaboratoryWork laboratoryWork = new LaboratoryWork();
            return laboratoryWork;
        }
    }
}
