  namespace ModelController;
  public struct Model
  {
    public string Models { get; set; }
    public string CarName {get; set; }

    public Model(string models, string name)
    {
      Models = models;
      CarName = name;

    }
  }