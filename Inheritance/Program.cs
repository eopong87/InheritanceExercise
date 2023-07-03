using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal- Done
            // give this class 4 members that all Animals have in common- done


            // Create a class Bird-Done
            // give this class 4 members that are specific to Bird- done
            // Set this class to inherit from your Animal Class- done

            // Create a class Reptile-Done
            // give this class 4 members that are specific to Reptile-done
            // Set this class to inherit from your Animal Class- done




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var myBird = new Bird();
            {
                myBird.BirdColor = "gray";
                myBird.BeakColor = "pink";
                myBird.CanFly = true;
                myBird.ColorOfWings = "black"; 
            }

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var Snake = new Reptile();
            {
                Snake.Age = 24;
                Snake.hasHeart = true;
                Snake.HasRoughSkin = false;
                Snake.LandOrSea = "land";
            }
            var MyAnimals = new Animal[] { myBird, Snake };

            foreach (var animal in MyAnimals)
            {
                Console.WriteLine($"This is its color? {animal.NumLegs}");
                Console.WriteLine($"It Lives by {animal.LandOrSea}!");
                Console.WriteLine($"does this animal move like this ?{animal.HasLegs}");
                Console.WriteLine($"Age:{animal.hasHeart} years Old");
            }
        }
    }
}
