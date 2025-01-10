public abstract class Insects : Animals {
  public bool hasWings;
}

public class Moth : Insects {
  public Moth(string n, int a, bool hW){
    name = n;
    age = a;
    hasWings = hW;
  }
  public override void Greeting(){
    Console.WriteLine($"Wow, it's a Moth, it's named {name} and is {age} years old.");
  }
}

public class Ant : Insects {
  public Ant(string n, int a, bool hW){
    name = n;
    age = a;
    hasWings = hW;
  }
  public override void Greeting(){
    Console.WriteLine($"Wow, it's an Ant, it's named {name} and is {age} years old.");
  }
}
