using System;

namespace Dealership {

  class Car
  {
    private string MakeModel;
    private int Price;
    private int Miles;

    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
    }

    public string GetMakeModel()
    {
      return MakeModel;
    }

    public int GetPrice()
   {
     return Price;
   }

   public int GetMiles()
   {
     return Miles;
   }

   // public string CarInfo()
   // {
   //   Console.WriteLine("This car is a {0}, with {1} miles on it, and it costs {2}", MakeModel, Miles, Price);
   // }

   public void SetPrice(int newPrice)
   {
     Price = newPrice;
   }

    public bool WorthBuying(int maxPrice)
    {
      return (Price < maxPrice);
    }

    public bool MaxMiles(int maxMiles)
    {
      return (Miles < maxMiles);
    }
  }
}
