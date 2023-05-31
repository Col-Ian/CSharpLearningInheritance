using System;

class CreditCardPayment : IMoney{
  // since it isn't public in the interface, it must be set to public
   public void Buy(double purchasePrice){
    Console.WriteLine("Purchase Price: $"+purchasePrice);
  }
}