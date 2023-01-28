using ModelController;

public class Brezza : Car
{

  public override string Name { get; set; }
  public string[] Colors { get; set; }
  public string Fuel { get; init; }
  public int Height { get; init; }
  public int Weight { get; init; }
  public Model[] Models { get; set; }
  public Fuel fuel;
  public Brezza(string carName, string[] colors, string fuel, int height, int weight, Model[] model)
  {
    Name = carName;
    Colors = colors;
    Fuel = fuel;
    Height = height;
    Weight = weight;
    Models = model;
  }

  public void CarModel(Model[] availableModels)
  {
    Console.WriteLine(Name);
        foreach(var modells in availableModels){
        if(modells.CarName == Name)
            Console.WriteLine($"And {this} is {modells.Models} model");
    }
    Console.WriteLine(fuel);
  }
  public override void HeightWeight()
  {
    Console.WriteLine($"Height: {Height}, Weight: {Weight}");
  }
  public Model[] this[Range range]
  {
    get => Models[range];
  }
  public override void FuelType()
  {
    Console.WriteLine();

  }
  public override void Sound(){
    var ftype1 = (Fuel)0;
    var ftype2 = (Fuel)2;
    if(Fuel == ftype1.ToString() | Fuel == ftype2.ToString()){
        Console.WriteLine($"Since it is {ftype1}, Sound is very low");
    }
    else Console.WriteLine($"Since it is {Fuel}, Sound will be high");

  }
  public override void LongOrShortDrive()
  {
    Console.WriteLine($"{this} is good for Long Drive");
  }
  public virtual void ColourAvailable(string clr){
      var result = Array.Find(Colors, element => element == clr.ToUpper());
      if(result == clr.ToUpper()){
        Console.WriteLine($"Yes, {this} is available in {clr} colour");
      }
      else{
        Console.WriteLine($"Sorry, {this} is not available in {clr} colour");
      }
  }
}
