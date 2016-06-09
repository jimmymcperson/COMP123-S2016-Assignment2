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

        // PRIVATE INSTANCE VARIABLES =====================================================

        private string[] _superPowers;
        private enum SuperPowerEnum { a = 1, b, c, d, e, f };

        // PUBLIC PROPTERTIES =====================================================

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
//                this._superPowers = ;
                Console.WriteLine("Superpowers set!");
                }
            }

        // CONSTRUCTORS =====================================================

        /** <summary>
        * This is the default/empty constructor.
        * </summary>
        *
        * @constructor SuperHero
        */
        public SuperHero()
            : base()
            {
            this._initializeAll();
            }

        public SuperHero(string name)
            : base(name)
            {
//            this._generateRandomPowers();
            }

        // PRIVATE METHODS =====================================================

        /** <summary>
         * This method initializes all fields at a default value.
         * </summary>
         *
         * @method _initializeAll
         * @returns {void}
         */
        private void _initializeAll()
            {
//            this._superPowers = ;
            }

        /** <summary>
         * This method randomly sets the superhero's superpowers.
         * </summary>
         *
         * @method _generateRandomPowers
         * @returns {void}
         */
        private void _generateRandomPowers()
            {
            Random roll = new Random();
            this._randomNumber(roll, 1, 7);
            }



        // PUBLIC METHODS =====================================================





        }
    }
