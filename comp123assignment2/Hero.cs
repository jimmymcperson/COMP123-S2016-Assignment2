using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace comp123assignment2
    {

    /** <summary>
     * This class defines a generic hero.
     * </summary>
     * 
     * @class Hero
     */
    public class Hero
        {

        // PRIVATE INSTANCE VARIABLES =====================================================

        private int _strength;
        private int _speed;
        private int _health;
        private string _name;

        // PUBLIC PROPTERTIES =====================================================

        /** <summary>
         * This is the property that read/writes the _name field.
         * </summary>
         *
         * @property {string} Name
         */
        public string Name
            {
            get
                {
                return this._name;
                }
            set
                {
                this._name = value;
                Console.WriteLine("Name set as: '{0}'", this._name);
                }
            }

        // CONSTRUCTORS =====================================================

        /** <summary>
         * This is the default/empty constructor.
         * </summary>
         *
         * @constructor Hero
         */
        public Hero()
            {
            this._defaultInitialize();
            Console.WriteLine("A hero has been generated!");
            }

        /** <summary>
         * This constructor takes a string and sets it as the hero's name.
         * It also randomly sets the hero's stats using the _generateAbilities method.
         * </summary>
         *
         * @constructor Hero
         * @param {string} name
         */
        public Hero(string name)
            {
            this.Name = name;
            this._generateAbilities();
            Console.WriteLine("A hero has been generated!");
            }

        // PRIVATE METHODS =====================================================

        /** <summary>
         * This method returns a random number between the specified values (minimum inclusive, maximum exclusive) using a Random object.
         * This method was taken from a lesson from COMP 100 at Centennial College.
         * </summary>
         *
         * @method _randomNumber
         * @params {Random} seed
         * @params {int} n1
         * @params {int} n2
         * @returns {int}
         */
        protected int _randomNumber(Random seed, int n1, int n2)
            {
            int number;
            number = seed.Next(n1, n2);  //selects the number for the parameter "seed" using the "Next" method from the "Random" class.
            return number;
            }

        /** <summary>
         * This method initializes all fields at a default value for the Hero class.
         * </summary>
         *
         * @method _defaultInitialize
         * @returns {void}
         */
        private void _defaultInitialize()
            {
            this._strength = 1;
            this._speed = 1;
            this._health = 1;
            this.Name = "Default Hero";
            }

        /** <summary>
         * This method randomly sets the hero's stats.
         * </summary>
         *
         * @method _generateAbilities
         * @returns {void}
         */
        private void _generateAbilities()
            {
            Random roll = new Random();
            this._strength = this._randomNumber(roll, 1, 101);
            this._speed = this._randomNumber(roll, 1, 101);
            this._health = this._randomNumber(roll, 1, 101);
            }

        /** <summary>
         * This method calculates whether or not an attack will hit.
         * </summary>
         *
         * @method _hitAttempt
         * @returns {bool}
         */
        private bool _hitAttempt()
            {
            Random roll = new Random();
            int attemptValue = this._randomNumber(roll, 1, 6);
            if (attemptValue < 5)
                {
                return false;
                }
            else
                {
                return true;
                }
            }

        /** <summary>
         * This method calculates the damage an attack dealt using the _strength field.
         * </summary>
         *
         * @method _hitDamage
         * @returns {int}
         */
        private int _hitDamage()
            {
            Random roll = new Random();
            int damageDealt;
            damageDealt = this._strength * this._randomNumber(roll, 1, 7);
            return damageDealt;
            }

        // PUBLIC METHODS =====================================================

        /** <summary>
         * This method displays the hero's name and parameters.
         * </summary>
         *
         * @method Show
         * @returns {void}
         */
        public void Show()
            {
            Console.WriteLine("====================\n{0}\n====================", this.Name);
            Console.WriteLine("Stats");
            Console.WriteLine("____________________");
            Console.WriteLine("HP  {0,3}", _health);
            Console.WriteLine("____________________");
            Console.WriteLine("STR {0,3}", _strength);
            Console.WriteLine("____________________");
            Console.WriteLine("SPD {0,3}", _speed);
            Console.WriteLine("____________________");
            }

        /** <summary>
         * This method performs a round of combat and displays the results to the console.
         * </summary>
         *
         * @method Fight
         * @returns {void}
         */
        public void Fight()
            {
            bool roundHit = this._hitAttempt();
            int roundDamage = this._hitDamage();

            Console.WriteLine("**************************************************");
            if (roundHit == true)
                {
                Console.WriteLine("{0} dealt {1} damage!", this._name, roundDamage);
                }
            else
                {
                Console.WriteLine("{0} missed!  ¯\\_(ツ)_/¯ ", this._name);
                }
            Console.WriteLine("**************************************************");
            }
        }
    }
