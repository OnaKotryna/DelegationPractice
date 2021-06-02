//Esybes 
class Animal {
  private var breed = "Dog"
  private var expectancy = 7
  private var birthSize = 10
  private var age = 2
  def GetBreed() = breed
  def GetLifeExpectancy() = expectancy
}
class Plant {
  private var species = "Cactus"
  private var waterNeed = 0.2
  def GetSpecies() = species
  def GetWaterNeed() = waterNeed
}
 class Human {
  private var age = 2
  private var birthSize = 40
  private var country = "Lithuania"
  private var citizenship = "lithuanian"
  def GetAged() = age
  def GetBirthSize() = birthSize
  def GetBirthCountry() = country
  def GetCitizenship() = citizenship
}

//Funkcionalumai
trait Dietary{
  def IsEdible() : Boolean = {
    var isIt = false
    isIt
  }
  def CalculateWaterConsumption(age:Int, exp:Double) : Double = {
    var water = (age + exp) * 0.5
    water
  }
}
trait Development{
  def CalculateGrowthSpeed(age:Int, size:Int) : Double = {
    var speed = size * 1.0 / age;
    speed
  }
  def PredictFullGrowthSize(exp:Int, size:Int) : Double = {
    var growthSize = size + exp * 1.9
    growthSize
  }
}
trait Movement{
  def Stand() = {
    println("Standing.")
  }
  def Walk() = {
    println("Walking.")
  }
  def Swing() = {
    println("Swinging.")
  }
}

// Daugybinis paveldejimas
class Dev_Diet_Plant extends Plant with Development with Dietary{}
class Dev_Mov_Human extends Human with Development with Movement{}
class Mov_Diet_Animal extends Animal with Movement with Dietary{}

// Keliu klasiu realizavimas
var animal = new Mov_Diet_Animal()
println(animal.GetBreed() + " is created.\nDietry: Is it Edible? " + animal.IsEdible() 
        + "\nMovement: Its movement ")
animal.Stand()
var human = new Dev_Mov_Human()
println(human.GetCitizenship() + " is created.\nDevelopment: Predicted height " + human.PredictFullGrowthSize(70, human.GetBirthSize())
       + "\nMovement: Its movement ")
human.Walk()
var plant = new Dev_Diet_Plant()
println(plant.GetSpecies() + " is created.\nDietry: Water need:" + plant.CalculateWaterConsumption(0, plant.GetWaterNeed())
       + "\nDevelompent: Its growing speed " + plant.CalculateGrowthSpeed(40, 30))