
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Transactions;

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

