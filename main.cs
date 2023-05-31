/*
  Proxy Design Pattern
  Inheritance
    Multiple inheritance not supported in C# (must use interfaces)
*/

using System;

class Program {
  public static void Main (string[] args) {
    CreditCardPayment cardPayment = new CreditCardPayment();

    cardPayment.Buy(1000.10);

    // Since OnlinePayment() does not implement the interface, you have to pass in any class object that implements the IMoney interface.
    OnlinePayment onlinePayment = new OnlinePayment(cardPayment);

    onlinePayment.MakeAPurchase(2000.22);
  }
}