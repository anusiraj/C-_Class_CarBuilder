class Santro : Car{
    public override string Name{get; set;} = "Santro";
    public Santro(){

    }
  public override void FuelType()
  {
   Console.WriteLine(Name.ToUpper());
  }
  public override void HeightWeight()
  {
    throw new NotImplementedException();
  }
  public void Sound(){}
  public override bool LongOrShortDrive()
  {
    throw new NotImplementedException();
  }
}