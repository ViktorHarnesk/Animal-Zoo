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
