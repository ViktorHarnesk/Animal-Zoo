
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Transactions;

class Zoo{
  public List<Animals> Animal;
  public Zoo(){
   List<Animals> Animal = new(); 
  }
  public void greetAnimals(){
    foreach(Animals a in Animal){
      a.Greeting();
    }
  }
  public void addAnimal(Animals a){
    a.Greeting();
    Animal.Add(a);
  }
  public void removeAnimal(int i){
    Animal.RemoveAt(i);
  }
  public Animals firstAnimal(){
    return Animal[1];
  }
}


public abstract class Animals{
  public string name ="";
  public int age;
  public abstract void Greeting();
}

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

class Program {
  public static void Main(){
    bool active = true;
    Zoo jail = new();
     Cat k = new("pelle",22,true);
         k.Greeting();
    while(active){
      switch(Console.ReadKey().KeyChar){
        case 'q':
        active = false;
        break;
        case 'a':
        Console.WriteLine("Enter animal type: ");
        string type = Console.ReadLine();
        Console.WriteLine("Enter animal name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter animal age: ");
        int age = Int32.Parse(Console.ReadLine());
        switch(type){
          case "Cat":
          Cat c = new(name, age, true);
        
          jail.addAnimal(c);
          break;
          case "Parrot":
          Parrot p = new(name, age, true);
          jail.addAnimal(p);
          break;
          case "Penguin":
          Penguin P = new(name, age, false);
          jail.addAnimal(P);
          break;
          case "Ant":
          Ant a = new(name, age, false);
          jail.addAnimal(a);
          break;
          case "Moth":
          Moth m = new(name, age, true);
          jail.addAnimal(m);
          break;
          case "Raven":
          Raven r = new(name, age, true);
          jail.addAnimal(r);
          break;
        }
        break;
        case 'r':
        Console.WriteLine("Select an index: ");
        int i = Int32.Parse(Console.ReadLine());
        jail.removeAnimal(i);
        break;
        case 'f':
        jail.firstAnimal();
        break;
      }
    }
  }
}

