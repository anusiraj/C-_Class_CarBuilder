public abstract class Car
{
    public abstract string Name{get; set;}
    public abstract void FuelType();
    public abstract void HeightWeight();
    public virtual void Sound() => Console.WriteLine("All cars has almost same sound");
    public abstract void LongOrShortDrive(); 
}