// Excercise for creating classes, objects and methods

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_creating_classes_and_objects
{
    enum WagonType
    {
        WagonTypeCargo,
        WagonTypePassenger,
        WagonTypeTank
    }
    enum WagonLevel
    {
        WagonLevelWood,
        WagonLevelMetall,
        WagonLevelLux,
        WagonLevelSoft,
        WagonLevelSeat,
        WagonLevelFood,
        WagonLevelIndustrial
    }
    enum WagonWheelbase
    {
        WagonWheelbaseWide,
        WagonWheelbaseNarrow
    }
    class Wagon
    {
        public WagonType type;
        public WagonLevel level;
        public WagonWheelbase wheelbase;

        //Creating Constructor
        //public void Wagon(string type, string level, string wheelbase)
        public  Wagon(WagonType type, WagonLevel level, WagonWheelbase wheelbase)
        {
            this.type = type;
            this.level = level;
            this.wheelbase = wheelbase;
        }

        public void DoorOpen()
        {
            /**
             implementing door opening
             */
        }
        public void Loader()
        {
            /**
            implementing cargo automatic loader
            */
        }

        public string WagonTypeToString(WagonType wt)
        {
            string wts = "";
            switch(wt)
            {
                case WagonType.WagonTypeCargo:
                    wts = "Cargo";
                    break;
                default:
                    Console.WriteLine(" Type of Wagon is not Cargo");
                    break;
            }
            return wts;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of Wagon class
            Wagon Wagon01 = new Wagon(
                WagonType.WagonTypeCargo,
                WagonLevel.WagonLevelFood,
                WagonWheelbase.WagonWheelbaseNarrow);
            Console.WriteLine("Type of Wagon is: {0}", Wagon01.WagonTypeToString(Wagon01.type));
            Console.ReadKey();
        }
    }
}
