public abstract class Mammal : Animals {
  public bool isNocturnal;
  public abstract bool isAsleep();
}

public class Cat : Mammal {
  public Cat(string n, int a, bool iN){
    name = n;
    age = a;
    isNocturnal = iN;
  }
  public override bool isAsleep(){
    return true;
  }
  public override void Greeting(){
    Console.WriteLine($"Wow, it's a Cat, it's named {name} and is {age} years old.");
  }
}