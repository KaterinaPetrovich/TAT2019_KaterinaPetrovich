using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_4
{
    /// <summary>
    /// class of lecture
    /// </summary>
    class Lecture:Material, ICloneable
    {
        List<LaboratoryWork> laboratoryWorks;
        List<Seminar> seminars;        
        public string text;

        enum Type
        {
            PDF,
            PPT,
            Unknown
        }

        Tuple<string, Type> presentation;
        /// <summary>
        /// constructor creates objects of class
        /// </summary>
        /// <param name="quantityOfLabWorks">quantity of laboratory works</param>
        /// <param name="quantityOfSeminars">quantity of seminars</param>
        public Lecture(int quantityOfLabWorks=3, int quantityOfSeminars=2)
        {
            text = "Text";
            description = "This is lecture";
            presentation=new Tuple<string, Type>("sdfg98765ew",Type.PDF);
            laboratoryWorks = new List<LaboratoryWork>();
            seminars = new List<Seminar>();
            for(int i=0; i< quantityOfLabWorks;i++)
            {
                LaboratoryWork laboratoryWork = new LaboratoryWork();
                laboratoryWorks.Add(laboratoryWork);
            }
            for (int i = 0; i < quantityOfSeminars; i++)
            {
                Seminar seminar = new Seminar();
                seminars.Add(seminar);
            }
        }
        /// <summary>
        /// constructor used for creating cloned objects
        /// </summary>
        /// <param name="laboratoryWorks">list of laboratory work</param>
        /// <param name="seminars">list of seminars</param>
        /// <param name="URI">identifier</param>
        public Lecture(List<LaboratoryWork> laboratoryWorks, List<Seminar> seminars, string URI)
        {
            text = "Text";
            description = "This is lecture";
            presentation = new Tuple<string, Type>(URI, Type.PDF);
            this.laboratoryWorks = new List<LaboratoryWork>();
            this.seminars = new List<Seminar>();

            foreach (LaboratoryWork laboratoryWork in laboratoryWorks)
            {
                this.laboratoryWorks.Add((LaboratoryWork)laboratoryWork.Clone());
            }

            foreach (Seminar seminar in seminars)
            {
                this.seminars.Add((Seminar)seminar.Clone());
            }
        }
        /// <summary>
        /// method clones object of class
        /// </summary>
        /// <returns>cloned object</returns>
        public object Clone()
        {
            Lecture lecture = new Lecture(laboratoryWorks, seminars, description);
            return lecture;
        }
    }
}
