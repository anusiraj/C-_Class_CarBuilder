using System;
using ModelController;

class Program
{
  public static void Main(string[] args)
  {
    var models = new Model[] { new Model("Sedan", "Brezza"), new Model("SUV", "Honda City"), new Model("HatchBack", "Santro") };
    var brezza = new Brezza(
        "Brezza",
        new string[] { "WHITE", "BLACK", "RED", "BLUE", "GREY" },
        "Diesal",
        170,
        1110,
        models
        );
    var availableModels = brezza[0..3];
    brezza.CarModel(availableModels);
    brezza.HeightWeight();
    brezza.Sound();
    brezza.LongOrShortDrive();
    brezza.ColourAvailable("yellow");
    Console.WriteLine("");
    var hondacity = new HondaCity(
        "Honda City",
        new string[] { "WHITE", "BLACK", "RED", "BLUE", "GREY" },
        "Diesal",
        150,
        1000,
        models
        );
    hondacity.CityModel(availableModels);
    hondacity.HtWt();
    hondacity.Sound();
    hondacity.LongOrShortDrive();
    hondacity.AvailableByColor("white");
    Console.WriteLine("");

    Car santro = new Santro();
    santro.FuelType();
    santro.Sound();
    santro.LongOrShortDrive();
  }

}

