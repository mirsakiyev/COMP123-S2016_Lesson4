using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lesson4
{
    /**
    * <summary>
    * The Student is derived from Person Class
    * </summary>
    * 
    * @class Student
    * @extends Person
    */
    public class Student : Person
    {

        //----------------------------------------------------------------------------------------------
        //--------------------------PRIVATE INSTANCE VARIABLES------------------------------------------
        //----------------------------------------------------------------------------------------------
        private string _studentID;
        private List<Course> _courses = new List<Course>();


        //----------------------------------------------------------------------------------------------
        //-----------------------------PUBLIC PROPERTIES------------------------------------------------
        //----------------------------------------------------------------------------------------------

        /**
        * <summary>
        * This property, StudentID, includes a getter and setter fot the 
        * </summary>
        * 
        * 
        */
        public string StudentID
        {
            get
            {
                return this._studentID;
            }
            set
            {
                this._studentID = value;
            }
        }

        public List<Course> Courses
        {
            get
            {
                return this._courses;
            }
            set
            {
                this._courses
            }
        }

        //----------------------------------------------------------------------------------------------
        //------------------------------------CONSTRUCTORS----------------------------------------------
        //----------------------------------------------------------------------------------------------

        /**
        * <summary>
        * This is constructor takes 3 arguments : name, age, studenID.
        * </summary>
        *
        * @constructor Student
        * @extends Person
        * @param {string} name
        * @param {int} age
        * @param {string} studentID
        */
        public Student(string name, int age, string studentID):base(name, age)
        {
            this.StudentID = studentID;
            
        }

        //----------------------------------------------------------------------------------------------
        //----------------------------PUBLIC METHODS----------------------------------------------------
        //----------------------------------------------------------------------------------------------

        /**
        * <summary>
        * This method enables the Studies behaviour for the Student class
        * </summary>
        * 
        * @method Studies
        * @returns {void}
        */
        public void Studies()
        {
            Console.WriteLine(this.Name+" studies.");
        }
    }
}
