using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lesson4
{
    /**
     * This is the course class - we are using this as
     * a custom data typr for our Teacher and Student classes
     *
     * @class Course
     */
    class Course
    {

        //----------------------------------------------------------------------------------------------
        //--------------------------PRIVATE INSTANCE VARIABLES------------------------------------------
        //----------------------------------------------------------------------------------------------
        private string _code;
        private string _description;



        public string Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
            }
        }


        public string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }



        //----------------------------------------------------------------------------------------------
        //------------------------------------CONSTRUCTORS----------------------------------------------
        //----------------------------------------------------------------------------------------------
        /**
       * <summary>
       * This constructor method takes 2 parameters: Code and Description
       * </summary>
       *
       * @constructor Course
       * @param {string} name
       * @param {string} description
       */

        public Course(string code, string description)
        {
            this.Code = code;
            this.Description = description;
        }
    }
}
