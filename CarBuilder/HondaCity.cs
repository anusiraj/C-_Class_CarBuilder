using ModelController;

class HondaCity : Brezza //just to learn how inheritance in normal class works
{
  public HondaCity(string carName, string[] colors, string fuel, int height, int weight, Model[] model) : base(carName, colors, fuel, height, weight, model)
  {
  }
  public void CityModel(Model[] availableModels)
  {
    Console.WriteLine(Name.ToUpper());
    base.CarModel(availableModels);
  }
  public void HtWt(){
    base.HeightWeight();
  }
  public override void Sound(){
    Console.WriteLine("Sound: Brum brum brummmm");
  }
  public override void LongOrShortDrive(){
    base.LongOrShortDrive();
  }
  public void AvailableByColor(string clr){
    base.ColourAvailable(clr);
  }
}