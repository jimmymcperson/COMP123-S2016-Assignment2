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
 * Version: 0.1.0 - Changed Fight() from Hero class. Cleaned up Program class.
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
            SuperHero heroOfJustice = new SuperHero("Hero of Justice");

            Console.WriteLine();

            heroOfJustice.ShowPowers();

            Console.WriteLine();
            Console.WriteLine();

            heroOfJustice.Show();

            Console.WriteLine();

            heroOfJustice.Fight();

            Console.WriteLine();

            }
        }
    }
