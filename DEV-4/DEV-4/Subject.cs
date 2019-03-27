using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_4
{
    /// <summary>
    /// class for subjects
    /// </summary>
    class Subject: ICloneable
    {
        string description;
        Guid guid;
        List<Lecture> lectures;
        /// <summary>
        /// constructor creates objects of class
        /// </summary>
        /// <param name="quantityOfLectures">quantity of lectures</param>
        public Subject(int quantityOfLectures = 3)
        {
            lectures = new List<Lecture>();
            guid = Guid.NewGuid();
            description = "This is subject";
            for (int i = 0; i < quantityOfLectures; i++)
            {
                Lecture lecture = new Lecture();
                lectures.Add(lecture);
            }
        }
        /// <summary>
        /// constructor used for creating cloned objects
        /// </summary>
        /// <param name="guid">guid</param>
        /// <param name="lectures">list of lectures</param>
        public Subject(Guid guid, List<Lecture> lectures)
        {
            this.lectures = new List<Lecture>();
            this.guid = guid;
            description = "This is subject";
            foreach (Lecture lecture in lectures)
            {
                this.lectures.Add((Lecture)lecture.Clone());
            }
        }
        /// <summary>
        /// indexator
        /// </summary>
        /// <param name="index">inputed index</param>
        /// <returns></returns>
        public Lecture this[int index]
        {
            get
            {
                return lectures[index];
            }
            set
            {
                lectures[index] = value;
            }

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
            return description;
        }
        /// <summary>
        /// overriden method 
        /// </summary>
        /// <param name="obj">object with compare</param>
        /// <returns>true if objects are the same</returns>
        public override bool Equals(object obj)
        {
            if (obj is Subject)
            {
                var subject = (Subject)obj;
                return this.GetGuid() == subject.GetGuid();
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        ///  method clones object of class
        /// </summary>
        /// <returns>cloned object</returns>
        public object Clone()
        {
            Subject subject = new Subject(guid,lectures);
            return subject;
        }
    }
}

