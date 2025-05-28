using System.Runtime.CompilerServices;

class Bike
{
  string bikename="ducati";
  string bikename2="suzuki";
  static void Main(string[] args)
  {
    Bike one=new Bike();
    Bike two=new Bike();
    Console.WriteLine(one.bikename);
    Console.WriteLine(two.bikename2);
  }
}