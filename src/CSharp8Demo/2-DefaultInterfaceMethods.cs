using System;
using System.Globalization;

// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-8.0/default-interface-methods

namespace CSharp8Demo
{
    public interface IShoppingCart
    {
        public static void SetDefaultName(string name)
        {
            defaultName = name;
        }

        // the interface can't have instance fields, the fields has to be static.
        private static string defaultName = "default";

        void CalculateSubTotal()
        {
            Console.WriteLine($"This is the {defaultName} CalculateSubTotal implementation of IShoppingCart.");
        }

        void CalculateTotal();
    }

    public interface ISubTotal
    {
        void CalculateSubTotal()
        {
            Console.WriteLine("This is the default ISubTotal implementation of CalculateSubTotal");
        }
    }

    public class ShoppingCart : IShoppingCart, ISubTotal
    {
        public void CalculateTotal()
        {
            Console.WriteLine("This is CalculateTotal in the ShoppingCart class.");
        }
    }

    public class BetterShoppingCart : IShoppingCart
    {
        public BetterShoppingCart()
        {
            IShoppingCart.SetDefaultName("DefaultBetterShoppingCart");
        }

        //public void CalculateSubTotal()
        //{
        //    Console.WriteLine("This is the BetterShoppingCart implementation of CalculateSubTotal.");
        //}

        public void CalculateTotal()
        {
            Console.WriteLine("This is CalculateTotal in the BetterShoppingCart class.");
        }
    }
}
