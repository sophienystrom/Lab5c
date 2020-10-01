using System;

class MainClass {
  public static void Main (string[] args) {
 
 int num = 0;
 Console.WriteLine ("Enter a number");
 int number = Convert.ToInt32 (Console.ReadLine());

 for (int counter  = 1; counter <= number; counter++) {
   if (number % counter == 0) {
     num++;
   }
 }
 
 if (num == 2) {
   Console.WriteLine (number + " is a prime number");
 }
 else {
   Console.WriteLine (number + " is not a prime number");
 }

 // this has to be the most difficult thing I have ever done i'm crying

  }
}