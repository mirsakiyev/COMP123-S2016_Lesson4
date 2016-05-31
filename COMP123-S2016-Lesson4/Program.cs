using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * COMP123-Lesson 4
 * Author : Aslan Mirsakiyev
 * Student ID : 300850326
 * Date : 31.05.2016
 * GitHub link : 
*/

namespace COMP123_S2016_Lesson4
{
    /**
     * This class is the driver class for our Program
     * 
     * @class Program
     */
    public class Program
    {
        /**
         * The main method for our driver class Program
         *
         * @method Main
         * @param {string[]} args
         */
        public static void Main(string[] args)
        {
            string separator = "-------------------------------------";

            //----------------------------------------------------------------------------------------------
            //--------------------Create an instance(tommy) of the Student class----------------------------
            //----------------------------------------------------------------------------------------------

            Student tommy = new Student("Tommy",20,"123456789");         
            tommy.SaysHello();
            tommy.Studies();
            tommy.Courses.Add(new Course("COMP123", "Programming"));
            Console.WriteLine(separator);

            //----------------------------------------------------------------------------------------------
            //----------------------Create an instance(tom) of the Teacher class----------------------------
            //----------------------------------------------------------------------------------------------

            Teacher tom = new Teacher("Tom",47,"T123456789");
            tom.SaysHello();
            tom.Teaches();
            tom.ShowAge();
            Console.WriteLine(separator);

        }
    }
}
