using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ==================================================================================================
 * Author: Jonathan Hao
 * Student#: 300869273
 * Date Modified: June 9, 2016
 * Description: This is a demonstration of inheritance in object-oriented programming.
 * Version: 0.0.1 - Initial commit.
 * ==================================================================================================
 */
namespace comp123assignment2
    {

    /** <summary>
     * This is the "driver" class for our program.
     * </summary>
     * 
     * @class Program
     */
    public class Program
        {

        /** <summary>
         * This is the "main" method.
         * </summary>
         * 
         * @method Main
         * @param {string[]} args
         * @returns {void}
         */
        public static void Main(string[] args)
            {
            Hero hero = new Hero("Imhotep");

            Console.WriteLine();

            hero.Show();

            Console.WriteLine();
            Console.WriteLine();

            hero.Fight();

            Console.WriteLine();

            }
        }
    }
