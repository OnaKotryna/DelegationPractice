using System;

namespace Delegavimas
{
    class Program
    {
        static void Main(string[] args)
        {

            Mov_Diet_Animal animal = new Mov_Diet_Animal();
            Console.WriteLine(animal.GetBreed() + " is created. \nDietry: Is it edible? " + animal.IsEdible() + "\nMovement: Its movement ");
            animal.Stand();
            Console.WriteLine("------------------");

            Dev_Mov_Human human = new Dev_Mov_Human();
            Console.WriteLine(human.GetCitizenship() + " is created.");
            double humanSize = human.PredictFullGrowthSize(70, human.GetBirthSize());
            Console.WriteLine("Age: " + human.GetAge() + "\nDevelompent: Predicted height " + humanSize + "\nMovement: Its movement ");
            human.Walk();
            Console.WriteLine("------------------");

            Dev_Diet_Plant plant = new Dev_Diet_Plant();
            Console.WriteLine(plant.GetSpecies() + " is created.");
            Console.WriteLine("Dietry: Water need " + plant.CalculateWaterConsumption(0, plant.GetWaterNeed()));
            double growthSpeed = plant.CalculateGrowthSpeed(40, 30);
            Console.WriteLine("Develompent: Its growing speed " + growthSpeed);
            
        }
    }
}
