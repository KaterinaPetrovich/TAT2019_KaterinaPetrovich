using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_4
{
    /// <summary>
    /// class for seminars
    /// </summary>
    class Seminar:Material, ICloneable
    {
        string[] tasks;
        string[] questions;
        string[] answers;
        /// <summary>
        /// constructor creates object of class
        /// </summary>
        /// <param name="quantityOfQuestions">quantity of questions</param>
        /// <param name="quantityOfTasks">quantity of tasks</param>
        public Seminar(int quantityOfQuestions=10, int quantityOfTasks = 10)
        {
            description = "This is seminar";
            tasks = new string[quantityOfTasks];
            questions = new string[quantityOfQuestions];
            answers= new string[quantityOfQuestions];
        }
        /// <summary>
        /// constructor used for creating cloned objects
        /// </summary>
        /// <param name="tasks">array of tasks</param>
        /// <param name="questions">array of questions</param>
        /// <param name="answers">array of answers</param>
        public Seminar(string[] tasks, string[] questions, string[] answers)
        {
            description = "This is seminar";
            this.tasks = tasks;
            this.questions = questions;
            this.answers = answers;
        }
        /// <summary>
        ///  method clones object of class
        /// </summary>
        /// <returns>cloned object</returns>
        public object Clone()
        {
            Seminar seminar = new Seminar(tasks,questions,answers);
            return seminar;
        }
    }
}
