using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lesson4
{
    /**
    * <summary>
    * The Teacher is derived from Person Class
    * </summary>
    * 
    * @class Student
    * @extends Person
    */
    class Teacher : Person
    {

        //----------------------------------------------------------------------------------------------
        //--------------------------PRIVATE INSTANCE VARIABLES------------------------------------------
        //----------------------------------------------------------------------------------------------

        private string _employeeID;

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
        public string EmployeeID
        {
            get
            {
                return this._employeeID;
            }
            set
            {
                this._employeeID = value;
            }
        }

        //----------------------------------------------------------------------------------------------
        //------------------------------------CONSTRUCTORS----------------------------------------------
        //----------------------------------------------------------------------------------------------

        /**
        * <summary>
        * This constructor method takes 3 parameters: name, age , employeeID
        * </summary>
        *
        * @constructor Teacher
        * @extends Person
        * @param {string} name
        * @param {int} age
        * @param {string} studentID
        */
        public Teacher(string name, int age, string employeeID)
            :base(name, age)
        {
            this.EmployeeID = employeeID;
        }

        //----------------------------------------------------------------------------------------------
        //----------------------------PUBLIC METHODS----------------------------------------------------
        //----------------------------------------------------------------------------------------------

        /**
        * <summary>
        * This method enables the Teaches behaviour for the Teacher class
        * </summary>
        * 
        * @method Studies
        * @returns {void}
        */
        public void Teaches()
        {
            Console.WriteLine(this.Name + " teaches.");
        }
    }
}
