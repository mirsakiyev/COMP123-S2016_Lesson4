﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lesson4
{
    /**
     * This class defines a generic Person
     *
     * @class Person
     * @field _name {string}
     */
    public class Person
    {
        //----------------------------------------------------------------------------------------------
        //--------------------------PRIVATE INSTANCE VARIABLES------------------------------------------
        //----------------------------------------------------------------------------------------------

        private string _name;
        private int _age;


        //----------------------------------------------------------------------------------------------
        //-----------------------------PUBLIC PROPERTIES------------------------------------------------
        //----------------------------------------------------------------------------------------------

        /**
         * This is a property for our private _name field
         * @property {string} Name
         */
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }


        /**
         * <summary>
         * This is a public property for our private _age field
         * </summary>
         * 
         * @property {int} Age
        */
        public int Age
        {
            get { return this._age; }
            set { this._age = value; }
        }


        //----------------------------------------------------------------------------------------------
        //------------------------------------CONSTRUCTORS----------------------------------------------
        //----------------------------------------------------------------------------------------------

        /**
         * <summary>
         *This is default empty constructor for the Person class
         * </summary>
         * 
         * 
         * @constructor Person
        */
        public Person()
        {
            // Initialize public properties
            this.Name = "unknown name";
            this._age = 0;

        }



        /**
        * <summary>This is the constructor that takes name as a parameter and passes 
        * it to the _name private instance variable
        * </summary>
        * 
        * @constructor Person
        * @param {string} name
       */
        public Person(string name)
        {
            this.Name = name;
            this.Age = 0;
        }


        /**
       * <summary>This is the constructor that takes age as a parameter and passes 
       * it to the _age private instance variable
       * </summary>
       * 
       * @constructor Person
       * @param {int} age
       * @param {string} name
      */
        public Person(int age)
        {
            this.Name = "unknown name";
            this.Age = age;
        }



        /**
       * <summary>This is the constructor that takes both name and age as a parameters
       * It assigns the local name value to the Name property
       * It assigns the local age value to the Age property
       * it to the _age private instance variable
       * </summary>
       * 
       * @constructor Person
       * @param {int} age
       * @param {string} name
      */
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }


        //----------------------------------------------------------------------------------------------
        //-----------------------------------METHODS----------------------------------------------------
        //----------------------------------------------------------------------------------------------

        /**
         * <summary>
         * This method ouputs the _name value with "says hello!!1" to the console
         * </summary>
         * 
         * @method SaysHello
         * @returns {void}
        */
        public void SaysHello()
        {
            Console.WriteLine(this.Name + " " + " says hello!!1");
        }


        /**
         * <summary>
         * This method ouputs the _name and the _age values 
         * in the following format: _name + "is" + _age + "years old".
         * </summary>
         * 
         * @method ShowAge
         * @returns {void}
        */
        public void ShowAge()
        {
            Console.WriteLine(this.Name + " is " + this.Age + " years old");
        }
    }
}
