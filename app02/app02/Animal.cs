using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app02
{
    class Animal
    {
        // Attributes (fields) that all Animals have
        // public means can be directly changed
        // after an object has been created
        public string name;
        public string sound;
        // static fields and methods belong to the class
        // A static field has the same value for all
        // objects of the Animal type
        static int numOfAnimals = 0;
        // A constructor sets default values for
        // fields when an object is created
        // This is the default constructor if no
        // parameters are sent
        public Animal() 
        {
            name = "No name";
            sound = "No sound";
            numOfAnimals++;
        }
        // You can create additonal constructors
        // but since we are definig defaults you
        // don't have to
        public Animal(string name = "No name")
        {
            // This refers to this objects name
            // instead of the name passed into
            // the constructor
            this.name = name;
            this.sound = "No Sound";
            numOfAnimals++;
        }
        public Animal(string name = "No name",
            string sound = "No sound")
        {
            this.name = name;
            this.sound = sound;
            numOfAnimals++;
        }
        // Capabilities (methods) that all Animals have
        public void MakeSound()
        {
            Console.WriteLine("{0} says {1}",
                name, sound);
        }
        public static int GetNumAnimals()
        {
            return numOfAnimals;
        }
    }
}
