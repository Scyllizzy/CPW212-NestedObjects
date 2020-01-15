using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    /// <summary>
    /// Represents a single college course.
    /// </summary>
    public class Course
    {
        /// <summary>
        /// The title of the course.
        /// ex. Programming Fundamentals
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Describes what the course covers/teaches in text.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The number of credits earned for completing the class.
        /// </summary>
        public byte Credits { get; set; }

        /// <summary>
        /// The unique course ID assigned to the course by the database. 
        /// </summary>
        public int CourseID { get; set; }
    }
}
