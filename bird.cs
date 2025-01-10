public abstract class Birds : Animals {
    public bool canFly;
    void Fly(int meters){

    }
}

public class Raven : Birds {
  public Raven(string n, int a, bool cF){
    name = n;
    age = a;
    canFly = cF;
  }
public override void Greeting(){
    Console.WriteLine($"Wow, it's a Raven, it's named {name} and is {age} years old.");
  }
  public void Fly(int distance){
    Console.WriteLine($"The bird flew {distance} meters.");
  }
}

public class Parrot : Birds {
  public Parrot(string n, int a, bool cF){
    name = n;
    age = a;
    canFly = cF;
  }
  public void Speak(string spoken){
    Console.WriteLine("The parrot responds: "+spoken);
  }
  public override void Greeting(){
  Console.WriteLine($"Wow, it's a Parrot, it's named {name} and is {age} years old.");
  }
   public void Fly(int distance){
    Console.WriteLine("The bird flew "+distance+" meters.");
  }
}

public class Penguin : Birds {
  public Penguin(string n, int a, bool cF){
    name = n;
    age = a;
    canFly = cF;
  }
  public override void Greeting(){
    Console.WriteLine($"Wow, it's a Penguin, it's named {name} and is {age} years old.");
  }
   public void Fly(int distance){
    Console.WriteLine("Sorry, this bird can't fly.");
  }
}