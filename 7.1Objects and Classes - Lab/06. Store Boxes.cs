using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Boxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string boxWord = Console.ReadLine();
            List<Box> boxes = new List<Box>();
            while (boxWord != "end")
            {
                string[] boxesArray = boxWord.Split(' ');
                string serialNumber = boxesArray[0];
                string itemName = boxesArray[1];
                int itemQuantity =int.Parse( boxesArray[2]);
                decimal itemPrice = decimal.Parse(boxesArray[3]);
                decimal finalPrice = itemQuantity * itemPrice;
                
                Item item = new Item(itemName,itemPrice);
                Box box = new Box(serialNumber, itemName, itemQuantity, itemPrice, finalPrice);
                boxes.Add(box);

                boxWord = Console.ReadLine();
                
            }
            
            foreach (Box box in boxes.OrderByDescending(x => x.FinalPrice))
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.ItemName} - ${ box.Price:f2}: { box.ItemQuantity}");
                Console.WriteLine($"-- ${ box.FinalPrice:f2}");
            }


        }
        public class Box
        {
            public Box(string serialNumber, string itemName, int itemQuantity, decimal itemPrice, decimal finalPrice)
            {
                SerialNumber = serialNumber;
                ItemName = itemName;
                ItemQuantity = itemQuantity;
                Price = itemPrice;
                FinalPrice = finalPrice;
                
            }

            public string SerialNumber { get; set; }
            public string ItemName { get; set; }
             
            public int ItemQuantity { get; set; }
            public decimal Price { get; set; }
            
            public decimal FinalPrice { get; set; }
          
        }
        private class Item
        {
            public Item(string name, decimal prce)
            {
                Name = name;
                Prce = prce;
            }

            public string Name { get; set; }

            public decimal Prce { get; set; }
        }
    }
}
