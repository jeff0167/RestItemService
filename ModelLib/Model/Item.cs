using System;

namespace ModelLib
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ItemQuality { get; set; }
        public double AmountQuantity { get; set; }

        public Item()
        {

        }

        public Item(int id, string name, string itemQuality, double amountQuantity)
        {
            Id = id;
            Name = name;
            ItemQuality = itemQuality;
            AmountQuantity = amountQuantity;
        }

        public override string ToString()
        {
            return $"id: {Id}, name: {Name}, item quality: {ItemQuality}, amount quantity: {AmountQuantity}";
        }
    }
}
