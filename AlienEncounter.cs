/* The purpose of this program is to facilitate intergalactic communication. Created by E. Farrell on October 6, 2021. */

using System;

namespace AlienEncounter
{
  class Martian
  {
    static void Main()
    {
     string name;
      Console.WriteLine("Greetings Earthling! What is your name?"); 
      name = Console.ReadLine();   
      Console.WriteLine($"Greetings {name}! Take me to your leader!");
    }
  }
}
