using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp123assignment2
    {

    /** <summary>
     * This class defines a "superhero" variant of the Hero class.
     * </summary>
     * 
     * @class SuperHero
     * @extends Hero
     */
    public class SuperHero : Hero
        {

        // PRIVATE INSTANCE VARIABLES ===============================================================

        private string[] _superPowers;

        // PUBLIC PROPTERTIES ===============================================================

        /** <summary>
        * This is the property that read/writes the _superPowers field.
        * </summary>
        *
        * @property {string[]} SuperPowers
        */
        public string[] SuperPowers
            {
            get
                {
                return _superPowers;
                }
            set
                {
                this._superPowers = value;
                Console.WriteLine("Superpowers set!");
                }
            }

        // CONSTRUCTORS ================================================================

        /** <summary>
        * This is the default/empty constructor.
        * </summary>
        *
        * @constructor SuperHero
        */
        public SuperHero()
            : base()
            {
            this._defaultInitialize();
            }

        /** <summary>
        * This constructor assigns superpowers for the _superPower field.
        * It also uses the Hero(string name) constructor from the hero class.
        * </summary>
        *
        * @constructor SuperHero
        */
        public SuperHero(string name)
            : base(name)
            {
            this._generateRandomPowers();
            }

        // PRIVATE METHODS ===============================================================

        /** <summary>
         * This method initializes all fields at a default value for the SuperHero class.
         * </summary>
         *
         * @method _defaultInitialize
         * @returns {void}
         */
        private void _defaultInitialize()
            {
            this._superPowers = new string[0];
            }

        /** <summary>
         * This method sets the _superPowers field with 3 random, distinct superpowers.
         * </summary>
         *
         * @method _generateRandomPowers
         * @returns {void}
         */
        private void _generateRandomPowers()
            {
            int count = 0;
            string[] possibleSuperPowers = new string[6] { "Super Speed", "Super Strength", "Body Armour", "Flight", "Fire Generation", "Weather Control" };
            string[] selectedSuperPowers = new string[3];
            string selectedPower;
            Random roll = new Random();
            while (count < 3)
                {
                selectedPower = possibleSuperPowers[this._randomNumber(roll, 0, 6)];
                if (!selectedSuperPowers.Contains(selectedPower)) //checks for duplicate powers
                    {
                    selectedSuperPowers[count] = selectedPower;
                    count++;
                    }
                }
            this.SuperPowers = selectedSuperPowers;
            }


        // PUBLIC METHODS ===============================================================

        /** <summary>
         * This method displays the values in the _superPowers field.
         * </summary>
         *
         * @method ShowPowers
         * @returns {void}
         */
         public void ShowPowers()
            {
            int i = 1;
            Console.WriteLine("====================\n{0}\n====================", this.Name);
            Console.WriteLine("Powers");
            foreach (string superpower in SuperPowers)
                {
                Console.WriteLine("____________________");
                Console.WriteLine(i + ". " + superpower);
                i++;
                }
            Console.WriteLine("____________________");
            }
        }
    }
